let openModalId = null;

// DOM References
const deleteIconButtons = document.querySelectorAll(".equipment button.delete");
const commentIconButtons = document.querySelectorAll(
	".equipment button.comments"
);
const confirmDeleteButton = document.querySelector("#confirm-delete");
const addCommentButton = document.querySelector("#add-comment");
const confirmAddCommentButton = document.querySelector("#submit-comment");
const commentInput = document.querySelector("#comment-input");
const newEquipmentButton = document.querySelector("button.new-equipment");
const equipmentNameInput = document.querySelector("#equipment-name");
const equipmentImageInput = document.querySelector("#equipment-image-location");
const equipmentDescriptionInput = document.querySelector(
	"#equipment-description"
);
const equipmentActiveInput = document.querySelector("#equipment-active");
const addEquipmentButton = document.querySelector("#new-equipment");

// Event listeners
deleteIconButtons.forEach(button => {
	const id = button.id;
	button.addEventListener("click", _ => showDeleteModal(id));
});
commentIconButtons.forEach(button => {
	const id = button.id;
	button.addEventListener("click", _ => handleOpenComments(id));
});
confirmDeleteButton.addEventListener("click", handleDelete);
addCommentButton.addEventListener("click", showAddCommentModal);
confirmAddCommentButton.addEventListener("click", handleAddComment);
commentInput.addEventListener("input", verifyCommentInput);
newEquipmentButton.addEventListener("click", showNewEquipmentModal);
equipmentNameInput.addEventListener("input", verifyNewEquipmentInput);
equipmentImageInput.addEventListener("input", verifyNewEquipmentInput);
equipmentDescriptionInput.addEventListener("input", verifyNewEquipmentInput);
addEquipmentButton.addEventListener("click", handleAddEquipment);

// Functions
function showDeleteModal(id) {
	MicroModal.show("delete-modal", {
		onShow: () => {
			openModalId = id;
		},
		onClose: () => {
			openModalId = null;
		},
	});
}

async function handleDelete() {
	let toastMessage = "";

	try {
		const response = await fetch("/techman/api/delete-equipment.php", {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				equipmentId: openModalId,
			}),
		});

		const data = await response.json();

		if (data.type === "error") {
			toastMessage = data.message;
		}

		if (data.type === "success") {
			toastMessage = "Equipamento excluído com sucesso!";

			const equipmentElement = document.getElementById(
				`equipment-${openModalId}`
			);
			const dividerElement = document.getElementById(`divider-${openModalId}`);

			equipmentElement.remove();

			if (dividerElement) {
				dividerElement.remove();
			}
		}
	} catch (error) {
		toastMessage = "Houve um erro ao excluir o equipamento";
	} finally {
		MicroModal.close("delete-modal");

		Toastify({
			text: toastMessage,
			duration: 3000,
			gravity: "bottom",
			position: "right",
		}).showToast();
	}
}

async function handleOpenComments(id) {
	try {
		const comments = await getComments(id);
		renderComments(comments);
	} catch (error) {
		Toastify({
			text: "Houve um erro ao acessar os comentários",
			duration: 3000,
			gravity: "bottom",
			position: "right",
		}).showToast();

		return;
	}

	MicroModal.show("comments-modal", {
		onShow: () => {
			openModalId = id;
		},
	});
}

async function getComments(equipmentId) {
	try {
		const response = await fetch("/techman/api/retrieve-comments.php", {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				equipmentId,
			}),
		});

		const data = await response.json();

		if (data.type === "error") {
			throw Error("Houve um erro ao acessar os comentários");
		}

		if (data.type === "success") {
			return data.message;
		}
	} catch (error) {
		throw error;
	}
}

function renderComments(comments) {
	const modalContent = document.getElementById("comments-modal-content");

	if (!comments.length) {
		modalContent.innerHTML =
			"<p>Não há nenhum comentário para esse equipamento.</p>";

		return;
	}

	modalContent.innerHTML = "";

	const ul = document.createElement("ul");
	comments.forEach(comment => {
		const date = new Date(comment.data).toLocaleDateString("pt-BR");

		ul.innerHTML += `
			<li>
				<h3>${comment.perfil} - ${date}</h3>
				<p>${comment.comentario}</p>
			</li>
			<hr />
		`;
	});

	modalContent.appendChild(ul);
}

function showAddCommentModal() {
	MicroModal.close("comments-modal");
	MicroModal.show("add-comment-modal", {
		onClose: () => {
			openModalId = null;
			commentInput.value = "";
		},
	});
}

async function handleAddComment() {
	const comment = commentInput.value;
	const equipmentId = openModalId;
	const date = toIsoString(new Date());

	try {
		const response = await fetch("/techman/api/add-comment.php", {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				comment,
				equipmentId,
				date,
			}),
		});

		const data = await response.json();

		if (data.type === "error") {
			throw Error("Houve um erro ao adicionar o comentário");
		}

		if (data.type === "success") {
			Toastify({
				text: "Sucesso! Comentário cadastrado para o equipamento.",
				duration: 3000,
				gravity: "bottom",
				position: "right",
			}).showToast();
		}
	} catch (error) {
		Toastify({
			text: "Houve um erro ao adicionar o comentário",
			duration: 3000,
			gravity: "bottom",
			position: "right",
		}).showToast();
	} finally {
		MicroModal.close("add-comment-modal");
	}
}

function verifyCommentInput() {
	if (commentInput.value.trim() !== "") {
		confirmAddCommentButton.removeAttribute("disabled");
	} else {
		confirmAddCommentButton.setAttribute("disabled", true);
	}
}

function showNewEquipmentModal() {
	MicroModal.show("new-equipment-modal", {
		onClose: () => {
			equipmentNameInput.value = "";
			equipmentImageInput.value = "";
			equipmentDescriptionInput.value = "";
			equipmentActiveInput.checked = true;
		},
	});
}

function verifyNewEquipmentInput() {
	if (
		equipmentNameInput.value.trim() !== "" &&
		equipmentImageInput.value.trim() !== "" &&
		equipmentDescriptionInput.value.trim() !== ""
	) {
		addEquipmentButton.removeAttribute("disabled");
	} else {
		addEquipmentButton.setAttribute("disabled", true);
	}
}

async function handleAddEquipment() {
	const name = equipmentNameInput.value;
	const imageLocation = equipmentImageInput.value;
	const description = equipmentDescriptionInput.value;
	const active = equipmentActiveInput.checked ? 1 : 0;
	const date = toIsoString(new Date());

	try {
		const response = await fetch("/techman/api/add-equipment.php", {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				name,
				imageLocation,
				description,
				active,
				date,
			}),
		});

		const data = await response.json();

		if (data.type === "error") {
			throw Error("Houve um erro ao adicionar o equipamento");
		}

		if (data.type === "success") {
			window.location.reload();

			Toastify({
				text: "Equipamento cadastrado com sucesso!",
				duration: 3000,
				gravity: "bottom",
				position: "right",
			}).showToast();
		}
	} catch (error) {
		Toastify({
			text: "Houve um erro ao adicionar o equipamento",
			duration: 3000,
			gravity: "bottom",
			position: "right",
		}).showToast();
	} finally {
		MicroModal.close("new-equipment-modal");
	}
}

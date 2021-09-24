let digits = [];
let passwordAnimationTimeoutID = null;
let passwordInserted = false;

// DOM References
const digitButtons = document.querySelectorAll(".digit");
const clearButton = document.querySelector(".clear");
const enterButton = document.querySelector(".enter");
const display = document.querySelector(".display");

// Event listeners
digitButtons.forEach(button => {
	const digit = parseInt(button.innerText);
	button.addEventListener("click", event => handleDigitClick(event, digit));
});

clearButton.addEventListener("click", clearPassword);

enterButton.addEventListener("click", handleEnterClick);

// Functions
function handleDigitClick(event, digit) {
	if (digits.length < 6) {
		digits.push(digit);
	}

	renderDisplay();

	if (digits.length === 6) {
		enterButton.removeAttribute("disabled");
		passwordInserted = true;
	}
}

function renderDisplay() {
	if (!digits.length) {
		display.innerText = "";
		return;
	}

	if (passwordInserted) {
		return;
	}

	const password = digits.toString().replace(/,/g, "").replace(/./g, "*");
	const lastDigit = digits[digits.length - 1];

	clearTimeout(passwordAnimationTimeoutID);

	display.innerText = `${password.slice(0, password.length - 1)}${lastDigit}`;

	passwordAnimationTimeoutID = setTimeout(() => {
		display.innerText = password;
	}, 1000);
}

function clearPassword(event) {
	clearTimeout(passwordAnimationTimeoutID);

	digits = [];
	passwordInserted = false;
	enterButton.setAttribute("disabled", true);

	renderDisplay();
}

async function handleEnterClick() {
	const password = digits.toString().replace(/,/g, "");
	let toastMessage = "";

	try {
		const response = await fetch("/techman/api/verify-password.php", {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				password,
			}),
		});

		const data = await response.json();

		if (data.type === "error") {
			toastMessage = data.message;
			clearPassword();
		}

		if (data.type === "success") {
			window.location = `/techman/config/login.php?password=${password}`;
		}
	} catch (error) {
		toastMessage = "Ocorreu um erro no processo";
	} finally {
		Toastify({
			text: toastMessage,
			duration: 3000,
			gravity: "top",
			position: "right",
		}).showToast();
	}
}

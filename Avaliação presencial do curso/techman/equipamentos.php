<?php
  session_start();

  if ($_SESSION["status"] != "ok") {
    header('location: ./index.php');
  }

  include "./config/connection.php";

  $query = "SELECT * FROM equipamentos WHERE ativo = 1";
  $result = mysqli_query($connection, $query);
  $equipments = mysqli_fetch_all($result, MYSQLI_ASSOC);

  mysqli_close($connection);

?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
  <?php include "./components/head.php"; ?>
  <link rel="stylesheet" href="./lib/micromodal/micromodal.css" />
  <link rel="stylesheet" href="./lib/toastify/toastify.css" />
  <link rel="stylesheet" href="./static/styles/equipamentos.css" />

  <title>Equipamentos | Techman</title>
</head>
<body>
  <nav>
    <img class="logo" src="/techman/static/images/techman.png" alt="Techman logo" />
    <div class="actions">
      <?php if ($_SESSION["perfil"] === "Administrador") { ?>
        <button class="new-equipment">Novo equipamento</button>
      <?php } ?>
      <a class="logout" href="./config/logout.php">
        <img src="/techman/static/icons/logout_sair.png" alt="Sair" />
      </a>
    </div>
  </nav>
  <main>
    <ul class="equipments">
      <?php $index = count($equipments); ?>
      <?php foreach ($equipments as $equipment) { ?>
        <?php $index -= 1; ?>
        <li class="equipment" id="equipment-<?php echo $equipment["id_equipamento"]; ?>">
          <img src="/techman/static/images/<?php echo $equipment["imagem"]; ?>" />
          <div class="content">
            <div class="details">
              <h2><?php echo $equipment["equipamento"]; ?></h2>
              <p class="description"><?php echo $equipment["descricao"]; ?></p>
            </div>
            <div class="actions">
              <button class="comments" id="<?php echo $equipment["id_equipamento"]; ?>">
                <img src="/techman/static/icons/comentario.png" alt="Comentários" />
              </button>
              <?php if ($_SESSION["perfil"] === "Administrador") { ?>
                <button class="delete" id="<?php echo $equipment["id_equipamento"]; ?>">
                  <img src="/techman/static/icons/deletar.png" alt="Deletar" />
                </button>
              <?php } ?>
            </div>
          </div>
        </li>
        <?php if ($index > 0) { ?>
          <hr id="divider-<?php echo $equipment["id_equipamento"]; ?>" />
        <?php } ?>
      <?php } ?>
    </ul>
  </main>

  <div class="modal micromodal-slide" id="new-equipment-modal" aria-hidden="true">
    <div class="modal__overlay" tabindex="-1" data-micromodal-close>
      <div class="modal__container" role="dialog" aria-modal="true" aria-labelledby="new-equipment-modal-title">
        <header class="modal__header">
          <h2 class="modal__title" id="new-equipment-modal-title">
            Cadastro de equipamento
          </h2>
          <button class="modal__close" aria-label="Close modal" data-micromodal-close></button>
        </header>
        <main class="modal__content" id="delete-modal-content">
          <input type="text" id="equipment-name" placeholder="Nome" />
          <input type="text" id="equipment-image-location" placeholder="Endereço da imagem" />
          <label for="equipment-description">Descrição</label>
          <textarea id="equipment-description"></textarea>
          <div class="checkbox-input">
            <input type="checkbox" id="equipment-active" checked />
            <label for="equipment-active">Ativo</label>
          </div>
        </main>
        <footer class="modal__footer">
          <button class="modal__btn modal__btn-primary" id="new-equipment" disabled>Cadastrar</button>
        </footer>
      </div>
    </div>
  </div>

  <div class="modal micromodal-slide" id="delete-modal" aria-hidden="true">
    <div class="modal__overlay" tabindex="-1" data-micromodal-close>
      <div class="modal__container" role="dialog" aria-modal="true" aria-labelledby="delete-modal-title">
        <header class="modal__header">
          <h2 class="modal__title" id="delete-modal-title">
            Exclusão de equipamento
          </h2>
          <button class="modal__close" aria-label="Close modal" data-micromodal-close></button>
        </header>
        <main class="modal__content" id="delete-modal-content">
          <p>
            Atenção! Tem certeza que deseja excluir o equipamento? Essa ação não poderá ser desfeita.
          </p>
        </main>
        <footer class="modal__footer">
          <button class="modal__btn modal__btn-danger" id="confirm-delete">Excluir</button>
        </footer>
      </div>
    </div>
  </div>

  <div class="modal micromodal-slide" id="comments-modal" aria-hidden="true">
    <div class="modal__overlay" tabindex="-1" data-micromodal-close>
      <div class="modal__container" role="dialog" aria-modal="true" aria-labelledby="comments-modal-title">
        <header class="modal__header">
          <h2 class="modal__title" id="comments-modal-title">
            Comentários
          </h2>
          <button class="modal__close" aria-label="Close modal" data-micromodal-close></button>
        </header>
        <main class="modal__content" id="comments-modal-content">
          <p>Não há nenhum comentário para esse equipamento.</p>
        </main>
        <footer class="modal__footer">
          <button class="modal__btn modal__btn-primary" id="add-comment">Adicionar comentário</button>
        </footer>
      </div>
    </div>
  </div>

  <div class="modal micromodal-slide" id="add-comment-modal" aria-hidden="true">
    <div class="modal__overlay" tabindex="-1" data-micromodal-close>
      <div class="modal__container" role="dialog" aria-modal="true" aria-labelledby="add-comment-title">
        <header class="modal__header">
          <h2 class="modal__title" id="add-comment-title">
            Cadastro de comentário
          </h2>
          <button class="modal__close" aria-label="Close modal" data-micromodal-close></button>
        </header>
        <main class="modal__content" id="comments-modal-content">
          <label for="comment-input">Comentário</label>
          <textarea id="comment-input"></textarea>
        </main>
        <footer class="modal__footer">
          <button class="modal__btn modal__btn-primary" id="submit-comment" disabled>Cadastrar</button>
        </footer>
      </div>
    </div>
  </div>

  <script src="./lib/toastify/toastify.js"></script>
  <script src="./lib/micromodal/micromodal.min.js"></script>
  <script src="./utils/toIsoString.js"></script>
  <script src="./static/scripts/equipamentos.js"></script>
</body>
</html>
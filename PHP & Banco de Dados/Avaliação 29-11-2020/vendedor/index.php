<?php
if (isset($_POST['submit-client'])) {
  include '../config/connection.php';

  $name = $_POST['nome'];
  $cpf = $_POST['cpf'];
  $status = $_POST['status'];
  $renda = $_POST['renda'];
  $credito = $_POST['credito'];

  if (mysqli_query($conn, "INSERT INTO pessoa (nome, cpf, status) VALUES ('$name', '$cpf', '$status')")) {
    $lastId = mysqli_insert_id($conn);
    if (mysqli_query($conn, "INSERT INTO clientes (pessoa_id, renda, credito) VALUES ('$lastId', '$renda', '$credito')")) {
      $error = 0;
    } else {
      $error = 1;
    }
  } else {
    $error = 1;
  }

  mysqli_close($conn);
}
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
  <?php include '../config/head.php'; ?>
  <link rel="stylesheet" href="../styles/main.css">
  <link rel="stylesheet" href="../styles/pages/vendedor/index.css">
</head>
<body>
  <?php include '../templates/navbar.php'; ?>
  <main>
    <section class="register-client">
      <header>
        <i class="material-icons large person">person</i>
        <h2>Cadastrar Clientes</h2>
      </header>
      <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
        <div class="input-field">
          <input type="text" name="nome" id="name" required>
          <label for="name">Nome</label>
        </div>
        <div class="input-field">
          <input type="text" name="cpf" id="cpf" required>
          <label for="cpf">CPF</label>
        </div>
        <!-- Status -->
        <label class="status">Status</label>
        <ul class="radios">
          <li>
            <label>
              <input type="radio" name="status" id="ativo" class="with-gap">
              <span>Ativo</span>
          </label>
          </li>
          <li>
            <label>
              <input type="radio" name="status" id="inativo" class="with-gap">
              <span>Inativo</span>
            </label>
          </li>
        </ul>

        <div class="input-field">
          <input type="number" min="0" name="renda" id="renda" required>
          <label for="renda">Renda</label>
        </div>
        <div class="input-field">
          <input type="number" min="0" name="credito" id="credito" required>
          <label for="credito">Crédito</label>
        </div>

        <!-- Buttons -->
        <div class="buttons">
          <button type="reset" class="btn waves-effect waves-light">
            Limpar
            <i class="material-icons right">clear</i>
          </button>

          <button type="submit" name="submit-client" class="btn waves-effect waves-light">
            Cadastrar
            <i class="material-icons right">send</i>
          </button>
        </div>
      </form>
    </section>
  </main>
  <script>
    M.toast({html: '<?php if ($error == 0) { echo 'Usuário cadastrado com sucesso'; } else if ($error == 1) { echo 'Houve um problema ao cadastrar o usuário'; } ?>', classes: '<?php if ($error == 0) { echo 'green'; } else if ($error == 1) { echo 'red'; } ?>'})
  </script>
</body>
</html>
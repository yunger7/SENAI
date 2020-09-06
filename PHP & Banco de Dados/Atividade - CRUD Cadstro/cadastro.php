<?php
include('config/conexao.php');

if (isset($_POST['submit'])) {
  // apos enviar form
  $nome = $_POST['nome'];
  $celular = $_POST['celular'];
  $email = $_POST['email'];

  $sql = "INSERT INTO exercicio(nome, celular, email) VALUES('$nome', '$celular', '$email')";

  if (mysqli_query($conn, $sql)) {
    mysqli_close($conn);
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Pessoa cadastrada com sucesso!');
    window.location.href = 'index.php';
    </script>
    ";
  } else {
    mysqli_close($conn);
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Houve um problema no cadastro');
    window.location.href = 'index.php';
    </script>
    ";
  }
}

?>

<!DOCTYPE html>
<html lang="pt-br">
<?php include 'templates/header.php'; ?>

<body>
  <h1 class="text-center my-4">Cadastro</h1>

  <form action="cadastro.php" method="POST" class="container center border bg-light d-flex flex-column p-5" style="width: 70vw; max-width: 800px; border-radius: 10px; min-width: 350px;">
    <label for="nome" class="mb-0">Nome: </label>
    <input type="text" name="nome" id="nome" placeholder="Digite seu nome" class="mb-3" style="min-width: 250px;" required>
    <label for="celular" class="mb-0">Celular: </label>
    <input type="tel" name="celular" id="celular" placeholder="Digite seu celular" class="mb-3" style="min-width: 250px;" required>
    <label for="email" class="mb-0">Email: </label>
    <input type="email" name="email" id="email" placeholder="Digite seu email" class="mb-3" style="min-width: 250px;" required>
    <input type="submit" name="submit" value="Cadastrar" class="btn btn-primary my-4 mx-auto" style="width: 50%; min-width: fit-content;">
  </form>
  <a href="index.php" class="btn btn-secondary d-block my-4 mx-auto" style="width: fit-content;">Voltar para HOME</a>
</body>

</html>
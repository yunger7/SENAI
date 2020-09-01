<?php
include 'conexao.php';

$sql = "SELECT * FROM usuario ORDER BY id";

$resultado = mysqli_query($conn, $sql);

$usuarios = mysqli_fetch_all($resultado, MYSQLI_ASSOC);

mysqli_free_result($resultado);
mysqli_close($conn);
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Visualização</title>

  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
  <style>
    header {
      margin: 1.5em 0;
      display: flex;
      justify-content: space-between;
    }
    h3 {
      margin-left: 30px;
    }
    a {
      margin-right: 30px;
    }
    table {
      text-align: center;
    }
  </style>
</head>

<body>
  <header>
    <h3>Cadastros registrados</h3>
    <a href="index.php" class="btn btn-primary">Voltar ao cadastro</a>
  </header>
  <table class="table table-striped">
    <thead>
      <th scope="col">ID</th>
      <th scope="col">Nome</th>
      <th scope="col">Celular</th>
      <th scope="col">Email</th>
    </thead>
    <tbody>
      <?php foreach ($usuarios as $usuario) : ?>
        <tr>
          <th scope="row"><?php echo $usuario['id'] ?></th>
          <td><?php echo $usuario['nome'] ?></td>
          <td><?php echo $usuario['celular'] ?></td>
          <td><?php echo $usuario['email'] ?></td>
        </tr>
      <?php endforeach ?>
    </tbody>
  </table>
</body>

</html>
<?php
include('config/conexao.php');

// EDITAR CADASTRO
if (isset($_POST['editar'])){
  $id_editar = $_POST['id-editar'];
  $nome = $_POST['nome'];
  $celular = $_POST['celular'];
  $email = $_POST['email'];

  $sql = "UPDATE exercicio set nome = '$nome', celular = '$celular', email = '$email' WHERE id = '$id_editar' ";

  if(mysqli_query($conn, $sql)){
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Cadastro editado com sucesso!');
    window.location.href = 'visualizar-editar.php';
    </script>
    ";
  } else {
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Houve um problema ao editar);
    window.location.href = 'visualizar-editar.php';
    </script>
    ";
  }
}


// BUSCAR REGISTROS DB
$sql = "SELECT * FROM exercicio ORDER BY nome" or die(mysqli_error($conn));
$resultado = mysqli_query($conn, $sql);
$usuarios = mysqli_fetch_all($resultado, MYSQLI_ASSOC);

// liberando memoria e fechando conexão
mysqli_free_result($resultado);
mysqli_close($conn);
?>

<!DOCTYPE html>
<html lang="pt-br">
<?php include('templates/header.php'); ?>

<body>
  <header class="my-4 d-flex justify-content-between align-items-center">
    <h1 class="ml-4">Visualizar e editar</h1>
    <a href="visualizar-editar.php" class="btn btn-secondary mr-4">Cancelar</a>
  </header>
  <table class="table text-center">
    <thead>
      <tr>
        <th scope="col">ID</th>
        <th scope="col">Nome</th>
        <th scope="col">Celular</th>
        <th scope="col">Email</th>
        <th scope="col">Configurações</th>
      </tr>
    </thead>
    <tbody>
      <?php foreach ($usuarios as $usuario) : ?>
        <?php if ($usuario['id'] == $_GET['id']) { ?>
          <form action="editar.php" method="POST">
            <input type="hidden" name="id-editar" value="<?php echo $usuario['id']; ?>">
            <tr>
              <th scope="row"><?php echo $usuario['id']; ?></th>
              <td><input type="text" name="nome" value="<?php echo $usuario['nome']; ?>"></td>
              <td><input type="tel" name="celular" value="<?php echo $usuario['celular']; ?>"></td>
              <td><input type="email" name="email" value="<?php echo $usuario['email']; ?>"></td>
              <td><input type="submit" name="editar" value="Editar" class="btn btn-success"></td>
            </tr>
          </form>
        <?php } else { ?>
          <tr>
            <th scope="row"><?php echo $usuario['id']; ?></th>
            <td><?php echo $usuario['nome']; ?></td>
            <td><?php echo $usuario['celular']; ?></td>
            <td><?php echo $usuario['email']; ?></td>
          </tr>
        <?php } ?>
      <?php endforeach; ?>
    </tbody>
  </table>
</body>

</html>
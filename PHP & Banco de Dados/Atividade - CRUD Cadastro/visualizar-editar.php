<?php
include('config/conexao.php');


// DELETAR CADASTRO
if(isset($_POST['excluir'])){
  $id_excluir = $_POST['id-excluir'];

  $sql = "DELETE FROM exercicio WHERE id='$id_excluir' ";

  if(mysqli_query($conn, $sql)){
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Cadastro excluído com sucesso!');
    window.location.href = 'visualizar-editar.php';
    </script>
    ";
  } else {
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Houve um problema ao excluir o cadastro');
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
    <a href="index.php" class="btn btn-secondary mr-4">Voltar para home</a>
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
        <tr>
          <th scope="row"><?php echo $usuario['id']; ?></th>
          <td><?php echo $usuario['nome']; ?></td>
          <td><?php echo $usuario['celular']; ?></td>
          <td><?php echo $usuario['email']; ?></td>
          <td>
            <a href="editar.php?id=<?php echo $usuario['id']; ?>" class="btn btn-warning">Editar</a>
            <form action="visualizar-editar.php" method="POST" style="display: inline;">
              <input type="hidden" name="id-excluir" value="<?php echo $usuario['id']; ?>">
              <input type="submit" name="excluir" value="Excluir" class="btn btn-danger ml-2">
            </form>
          </td>
        </tr>
      <?php endforeach; ?>
    </tbody>
  </table>
</body>

</html>
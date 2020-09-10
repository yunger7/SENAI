<?php
include('config/conexao.php');

if(isset($_POST['editar'])){
  $id_editar = $_POST['id-editar'];
  $nome = $_POST['nome-musica'];
  $cantor_banda = $_POST['cantor-banda'];
  $tipo = $_POST['tipo'];
  $duracao = $_POST['duracao'];
  $ano = $_POST['ano'];

  $sql = "UPDATE playlist SET nome_musica = '$nome', cantor_banda = '$cantor_banda', tipo = '$tipo', duracao = '$duracao', ano = '$ano' WHERE id = '$id_editar' ";

  if(mysqli_query($conn, $sql)){
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Música atualizada com sucesso!');
    location.href = 'editar-deletar.php';
    </script>
    ";
  } else {
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Houve um problema ao atualizar a música');
    location.href = 'editar-deletar.php';
    </script>
    ";
  }
}

// BUSCAR REGISTROS
$sql = "SELECT * FROM playlist ORDER BY id";
$res = mysqli_query($conn, $sql);
$musicas = mysqli_fetch_all($res, MYSQLI_ASSOC);

mysqli_free_result($res);
mysqli_close($conn);
?>

<!DOCTYPE html>
<html lang="pt-br">
<?php include('templates/header.php'); ?>
<header class="my-4 px-4 d-flex justify-content-between align-items-center" style="max-width: 1200px; margin: 1em auto;">
  <h1 class="h2">Editar / Deletar</h1>
  <a href="index.php" class="btn btn-secondary"> <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-arrow-left" fill="currentColor" xmlns="http://www.w3.org/2000/svg" style="margin-bottom: 3px;">
      <path fill-rule="evenodd" d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z" />
    </svg> Voltar para HOME</a>
</header>

<table class="table text-center border table-hover" style="max-width: 1200px; margin: 1em auto;">
  <thead>
    <tr>
      <th scope="col">ID</th>
      <th scope="col">Nome</th>
      <th scope="col">Cantor ou Banda</th>
      <th scope="col">Tipo</th>
      <th scope="col">Duração</th>
      <th scope="col">Ano</th>
      <th scope="col">Configuração</th>
    </tr>
  </thead>
  <tbody>
    <?php foreach ($musicas as $musica) : ?>
      <?php if ($musica['id'] == $_GET['id']) { ?>
        <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
          <input type="hidden" name="id-editar" value="<?php echo $musica['id']; ?>">
          <tr>
            <th scope="row"><?php echo $musica['id']; ?></th>
            <td><input type="text" name="nome-musica" value="<?php echo $musica['nome_musica']; ?>" class="mb-3 w-75 mx-auto" required></td>
            <td><input type="text" name="cantor-banda" value="<?php echo $musica['cantor_banda'] ?>" class="mb-3 w-75 mx-auto" required></td>
            <td><select name="tipo" class="mb-3 w-75 mx-auto" style="height: 30px;" required>
                <option value="" disabled selected>Tipo</option>
                <option value="sertanejo">Sertanejo</option>
                <option value="rock">Rock</option>
                <option value="jazz">Jazz</option>
                <option value="lo-fi">Lo-Fi</option>
                <option value="pop">Pop</option>
                <option value="eletronica">Eletrônica</option>
                <option value="bossa-nova">Bossa Nova</option>
                <option value="samba">Samba</option>
              </select></td>
            <td><input type="text" name="duracao" value="<?php echo $musica['duracao'] ?>" placeholder="HH:MM:SS" class="mb-3 w-75 mx-auto" required></td>
            <td>
            <input type="text" name="ano" value="<?php echo $musica['ano'] ?>" placeholder="AAAA" class="mb-3 w-75 mx-auto" required>
            </td>
            <td><input type="submit" name="editar" value="Editar" class="btn btn-success"></td>
          </tr>
        </form>
      <?php } else { ?>
        <tr>
          <th scope="row"><?php echo $musica['id']; ?></th>
          <td><?php echo $musica['nome_musica']; ?></td>
          <td><?php echo $musica['cantor_banda']; ?></td>
          <td><?php echo $musica['tipo']; ?></td>
          <td><?php echo $musica['duracao']; ?></td>
          <td><?php echo $musica['ano']; ?></td>
        </tr>
      <?php } ?>
    <?php endforeach; ?>
  </tbody>

</table>

<?php include('templates/footer.php'); ?>

</html>
<?php
include('config/conexao.php');

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
    <?php foreach($musicas as $musica): ?>
      <tr>
        <th scope="row"><?php echo $musica['id']; ?></th>
        <td><?php echo $musica['nome_musica']; ?></td>
        <td><?php echo $musica['cantor_banda']; ?></td>
        <td><?php echo $musica['tipo']; ?></td>
        <td><?php echo $musica['duracao']; ?></td>
        <td><?php echo $musica['ano']; ?></td>
        <td>
          <a href="" class="btn btn-warning">Editar</a>
          <form action="editar-deletar.php" method="POST" style="display: inline;">
            <input type="hidden" name="id-deletar" value="<?php echo $musica['id']; ?>">
            <input type="submit" name="excluir" value="Excluir" class="btn btn-danger ml-2">
          </form>
        </td>
      </tr>
    <?php endforeach; ?>
  </tbody>

</table>

<?php include('templates/footer.php'); ?>

</html>
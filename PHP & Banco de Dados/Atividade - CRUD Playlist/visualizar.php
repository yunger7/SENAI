<?php
include('config/conexao.php');

$sql = "SELECT * FROM playlist ORDER BY nome_musica";
$res = mysqli_query($conn, $sql);
$musicas = mysqli_fetch_all($res, MYSQLI_ASSOC);

mysqli_free_result($res);
mysqli_close($conn);
?>

<!DOCTYPE html>
<html lang="pt-vr">
<?php include('templates/header.php'); ?>
<header class="my-4 px-4 d-flex justify-content-between align-items-center" style="max-width: 1000px; margin: 1em auto;">
  <h1 class="h2">Visualização</h1>
  <a href="index.php" class="btn btn-secondary"> <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-arrow-left" fill="currentColor" xmlns="http://www.w3.org/2000/svg" style="margin-bottom: 3px;">
      <path fill-rule="evenodd" d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z" />
    </svg> Voltar para HOME</a>
</header>

<!-- Visualização usando grid do bootstrap -->
<div class="container">
  <div class="row justify-content-around">
    <?php foreach ($musicas as $musica) : ?>
      <div class="col-3 text-center bg-light p-4" style="border-radius: 10px;">
        <p><svg width="2.3em" height="2.3em" viewBox="0 0 16 16" class="bi bi-music-note-beamed" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
            <path d="M6 13c0 1.105-1.12 2-2.5 2S1 14.105 1 13c0-1.104 1.12-2 2.5-2s2.5.896 2.5 2zm9-2c0 1.105-1.12 2-2.5 2s-2.5-.895-2.5-2 1.12-2 2.5-2 2.5.895 2.5 2z" />
            <path fill-rule="evenodd" d="M14 11V2h1v9h-1zM6 3v10H5V3h1z" />
            <path d="M5 2.905a1 1 0 0 1 .9-.995l8-.8a1 1 0 0 1 1.1.995V3L5 4V2.905z" />
          </svg></p>
        <p><?php echo $musica['nome_musica']; ?></p>
        <p><?php echo $musica['cantor_banda']; ?></p>
        <p><?php echo $musica['tipo']; ?></p>
        <p><?php echo $musica['duracao']; ?></p>
        <p><?php echo $musica['ano']; ?></p>
      </div>
    <?php endforeach; ?>
  </div>
</div>

<?php include('templates/footer.php'); ?>

</html>
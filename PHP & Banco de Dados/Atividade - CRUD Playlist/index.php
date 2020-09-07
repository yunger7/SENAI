<!DOCTYPE html>
<html lang="pt-br">
<?php include('templates/header.php'); ?>
<h1 class="text-center my-4">CRUD - Playlist de Músicas</h1>
<p class="text-center my-4">Luís Galete Faldão - TDS04</p>
<section class="bg-light text-center w-75 mx-auto" style="height: 50vh; border-radius: 10px;">
  <ul class="list-unstyled d-flex flex-column justify-content-center align-items-center" style="width: 100%; height: 100%;">
    <li><a href="add-music.php" class="btn btn-primary my-3" style="width: 30vw;">Adicionar Músicas</a></li>
    <li><a href="visualizar.php" class="btn btn-primary my-3" style="width: 30vw;">Visualizar</a></li>
    <li><a href="editar-deletar.php" class="btn btn-warning my-3" style="width: 30vw;">Editar/Deletar</a></li>
  </ul>
</section>

<?php include('templates/footer.php') ?>
</html>
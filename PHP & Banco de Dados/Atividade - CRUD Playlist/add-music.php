<?php
if(isset($_POST['submit'])){
  // quando enviar o form
  include('config/conexao.php');

  // VERIFICAR SE JÁ EXISTE NO BANCO DE DADOS
  // verificação feita apenas pelo nome da música
  $nome_musica = $_POST['nome-musica'];
  $check = "SELECT * FROM playlist WHERE nome_musica = '$nome_musica'";
  $res = mysqli_query($conn, $check);
  $exist = mysqli_fetch_array($res, MYSQLI_NUM);

  // liberando memoria
  mysqli_free_result($res);

  if($exist[0] > 1) {
    // já existe no banco de dados
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Usuário já cadastrado no banco de dados');
    window.location.href = 'add-music.php';
    </script>
    ";

    mysqli_close($conn);
  } else {
    // não existe no banco de dados
    $cantor_banda = $_POST['cantor-banda'];
    $tipo = $_POST['tipo'];
    $duracao = $_POST['duracao'];
    $ano = $_POST['ano'];
    // validação da duração e ano foi feita no banco de dados
  
    $sql = "INSERT INTO playlist(nome_musica, cantor_banda, tipo, duracao, ano) VALUES('$nome_musica', '$cantor_banda', '$tipo', '$duracao', '$ano')";
  
    if(mysqli_query($conn, $sql)){
      echo "
        <script language='javascript' type='text/javascript'>
        alert('Música cadastrada com sucesso!');
        window.location.href = 'index.php';
        </script>    
      ";

      mysqli_close($conn);
    } else {
      echo "
      <script language='javascript' type='text/javascript'>
      alert('Houve um problema ao cadastrar a música :(');
      window.location.href = 'index.php';
      </script>    
    ";

      mysqli_close($conn);
    }
  }
}
?>

<!DOCTYPE html>
<html lang="pt-br">
<?php include('templates/header.php'); ?>
<header class="my-4 px-4 d-flex justify-content-between align-items-center" style="max-width: 1000px; margin: 1em auto;">
  <h1 class="h2">Adicionar Músicas</h1>
  <a href="index.php" class="btn btn-secondary"> <svg width="1em" height="1em" viewBox="0 0 16 16" class="bi bi-arrow-left" fill="currentColor" xmlns="http://www.w3.org/2000/svg" style="margin-bottom: 3px;">
  <path fill-rule="evenodd" d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"/>
</svg> Voltar para HOME</a>
</header>

<form action="add-music.php" method="POST" class="d-flex flex-column p-5" style="max-width: 1080px; margin: 1em auto;">
  <label for="nome-musica" class="m-0 w-75 mx-auto">Nome da música</label>
  <input type="text" name="nome-musica" id="nome-musica" placeholder="Digite o nome da música" class="mb-3 w-75 mx-auto" required>
  <label for="cantor-banda" class="m-0 w-75 mx-auto">Cantor ou Banda</label>
  <input type="text" name="cantor-banda" id="cantor-banda" placeholder="Digite o nome do cantor/banda" class="mb-3 w-75 mx-auto" required>
  <label for="tipo" class="m-0 w-75 mx-auto">Tipo da música</label>
  <select name="tipo" id="tipo" class="mb-3 w-75 mx-auto" required>
    <option value="" disabled selected>Selecione o tipo da música</option>
     <option value="sertanejo">Sertanejo</option>
     <option value="rock">Rock</option>
     <option value="jazz">Jazz</option>
     <option value="lo-fi">Lo-Fi</option>
     <option value="pop">Pop</option>
     <option value="eletronica">Eletrônica</option>
     <option value="bossa-nova">Bossa Nova</option>
     <option value="samba">Samba</option>
  </select>
  <label for="duracao" class="m-0 w-75 mx-auto">Duração</label>
  <input type="text" name="duracao" id="duracao" placeholder="HH:MM:SS" class="mb-3 w-75 mx-auto" required>
  <label for="ano" class="m-0 w-75 mx-auto">Ano</label>
  <input type="text" name="ano" id="ano" placeholder="AAAA" class="mb-3 w-75 mx-auto" required>
  <input type="submit" name="submit" value="Adicionar Música" class="btn btn-primary my-4 w-50 mx-auto">
</form>

<?php include('templates/footer.php'); ?>

</html>
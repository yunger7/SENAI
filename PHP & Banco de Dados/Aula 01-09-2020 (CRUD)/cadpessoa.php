<?php
include("conecta.php");

$nome = $_POST['nome'];
$idade = $_POST['idade'];

$sql = "INSERT INTO teste(nome, idade) VALUES('$nome', '$idade')";

if(mysqli_query($conn, $sql)){
  echo "<script language='javascript' type='text/javascript'>
  alert('Pessoa cadastrada com sucesso!');
  window.location.href = 'index.php';
  </script>";
} else {
  echo "<script language='javascript' type='text/javascript'>
  alert('Pessoa nao foi cadastrada');
  window.location.href = 'index.php';
  </script>";
}

mysqli_close($conn);
?>
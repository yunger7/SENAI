<?php
include('conecta.php');

$id = $_GET['id'];

$sql = "DELETE FROM teste WHERE id='$id'";

if(mysqli_query($conn, $sql)){
  echo "<script language='javascript' type='text/javascript'>
  alert('Pessoa excluída com sucesso!');
  window.location.href = 'index.php';
  </script>";
} else {
  echo "<script language='javascript' type='text/javascript'>
  alert('Pessoa nao foi excluída!');
  window.location.href = 'index.php';
  </script>";
}

mysqli_close($conn);

?>
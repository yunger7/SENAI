<?php
  include("conecta.php");

  $id = $_GET['id'];
  $nome = $_POST['nome'];
  $idade = $_POST['idade'];

  $sql = "UPDATE teste SET nome = '$nome', idade = '$idade' WHERE id = '$id'";

  if(mysqli_query($conn, $sql)){
    echo "<script language='javascript' type='text/javascript'>
    alert('Pessoa atualizada com sucesso!');
    window.location.href = 'index.php';
    </script>";
  } else {
    echo "<script language='javascript' type='text/javascript'>
    alert('Pessoa nao atualizada!');
    window.location.href = 'index.php';
    </script>";
  }
?>
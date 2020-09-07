<?php
$conn = new mysqli('localhost', 'root', '', 'aula');

if(!$conn){
  die("Conexao falhou: " . mysqli_connect_error());
}
?>
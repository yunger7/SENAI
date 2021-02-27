<?php
$conn = new mysqli('localhost', 'root', '', 'aula');

if(!$conn){
  die('Conexão falhou: ' . mysqli_connect_error());
}
?>
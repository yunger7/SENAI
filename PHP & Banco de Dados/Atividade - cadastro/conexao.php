<?php
$conn = mysqli_connect('localhost', 'root', '', 'cadastro');

if(!$conn){
  echo 'Conexão falhou: ' .  mysqli_connect_error();
}
?>
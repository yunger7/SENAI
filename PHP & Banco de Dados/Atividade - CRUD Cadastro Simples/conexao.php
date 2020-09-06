<?php

$conn = mysqli_connect('localhost', 'root', '', 'cadastro');

if(!$conn){
  echo 'Conexao falhou: ' . mysqli_connect_error();
}
?>
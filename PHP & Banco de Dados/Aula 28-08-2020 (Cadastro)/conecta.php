<?php
  $servername = "localhost";
  $database = "aula";
  $username = "root";
  $password = "";
  $conn = new mysqli($servername, $username, $password, $database);

  if(!$conn){
    die(mysqli_connect_error());
  }
?>
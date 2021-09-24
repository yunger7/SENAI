<?php
  $servername = "localhost";
  $database_name = "techman";
  $database_username = "root";
  $database_password = "";
  
  $connection = new mysqli($servername, $database_username, $database_password, $database_name);
  
  if (!$connection) {
    die(mysqli_connect_error());
  }

?>
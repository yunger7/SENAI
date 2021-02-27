<?php
$servername = "localhost";
$database = "avaliacao_final";
$username = "root";
$databasePassword = "";

$conn = mysqli_connect($servername, $username, $databasePassword, $database);

if (!$conn) {
  die(mysqli_connect_error());
}
?>
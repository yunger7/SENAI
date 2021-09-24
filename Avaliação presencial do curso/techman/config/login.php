<?php

$password = $_GET["password"];

if (!isset($password)) {
  echo "Password is not set";
}

include "./connection.php";
session_start();

$clean_password = mysqli_escape_string($connection, $password);
$query = "SELECT * FROM usuarios JOIN perfis ON perfis.id_perfil = usuarios.fk_id_perfil WHERE senha = '$clean_password';";
$result = mysqli_query($connection, $query) or die(mysqli_connect_error());

$user = mysqli_fetch_array($result);

$_SESSION["id"] = $user["id_usuario"];
$_SESSION["perfil"] = $user["perfil"];
$_SESSION["id_perfil"] = $user["id_perfil"];
$_SESSION["status"] = "ok";

header("Location: ../equipamentos.php");

mysqli_close($connection);

?>
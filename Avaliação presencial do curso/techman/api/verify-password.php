<?php

$_POST = json_decode(file_get_contents('php://input'), true);
$password = $_POST["password"] ?? null;

class Response {
  public $type;
  public $message;

  public function __construct($type, $message) {
    $this->type = $type;
    $this->message = $message;
  }
}

if (!isset($password)) {
  return print json_encode(new Response("error", "Senha incorreta"));
}

include "../config/connection.php";

$clean_password = mysqli_escape_string($connection, $password);
$query = "SELECT * FROM usuarios WHERE senha = '$clean_password'";
$result = mysqli_query($connection, $query) or die(mysqli_connect_error());

if (mysqli_num_rows($result) > 0) {
  return print json_encode(new Response("success", "ok"));
} else {
  return print json_encode(new Response("error", "Senha incorreta"));
}

mysqli_close($connection);

?>
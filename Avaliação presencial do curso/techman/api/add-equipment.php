<?php

$_POST = json_decode(file_get_contents('php://input'), true);
$name = $_POST["name"] ?? null;
$image_location = $_POST["imageLocation"] ?? null;
$description = $_POST["description"] ?? null;
$active = $_POST["active"] ?? null;
$date = $_POST["date"] ?? null;

class Response {
  public $type;
  public $message;

  public function __construct($type, $message) {
    $this->type = $type;
    $this->message = $message;
  }
}

if (!isset($name) || !isset($image_location) || !isset($description) || !isset($active) || !isset($date)) {
  return print json_encode(new Response("error", "Houve um problema ao adicionar o equipamento"));
}

include "../config/connection.php";

$clean_name = mysqli_escape_string($connection, $name);
$clean_image_location = mysqli_escape_string($connection, $image_location);
$clean_description = mysqli_escape_string($connection, $description);
$clean_active = mysqli_escape_string($connection, $active);
$clean_date = mysqli_escape_string($connection, $date);

$query = "INSERT INTO equipamentos (equipamento, imagem, descricao, ativo, data) VALUES ('$clean_name', '$clean_image_location', '$clean_description', '$clean_active', '$clean_date')";
mysqli_query($connection, $query) or die(mysqli_connect_error());

return print json_encode(new Response("success", "ok"));

mysqli_close($connection);

?>
<?php

session_start();

$_POST = json_decode(file_get_contents('php://input'), true);
$comment = $_POST["comment"] ?? null;
$equipment_id = $_POST["equipmentId"] ?? null;
$date = $_POST["date"] ?? null;
$profile_id = $_SESSION["id_perfil"];

class Response {
  public $type;
  public $message;

  public function __construct($type, $message) {
    $this->type = $type;
    $this->message = $message;
  }
}

if (!isset($equipment_id) || !isset($comment) || !isset($date)) {
  return print json_encode(new Response("error", "Houve um problema ao adicionar o comentário"));
}

include "../config/connection.php";

$clean_comment = mysqli_escape_string($connection, $comment);
$clean_equipment_id = mysqli_escape_string($connection, $equipment_id);
$clean_date = mysqli_escape_string($connection, $date);

$query = "INSERT INTO comentarios (comentario, data, fk_id_equipamento, fk_id_perfil) VALUES ('$clean_comment', '$clean_date', '$clean_equipment_id', '$profile_id')";
mysqli_query($connection, $query) or die(mysqli_connect_error());

return print json_encode(new Response("success", "ok"));

mysqli_close($connection);

?>
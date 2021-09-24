<?php

$_POST = json_decode(file_get_contents('php://input'), true);
$equipment_id = $_POST["equipmentId"] ?? null;

class Response {
  public $type;
  public $message;

  public function __construct($type, $message) {
    $this->type = $type;
    $this->message = $message;
  }
}

if (!isset($equipment_id)) {
  return print json_encode(new Response("error", "Houve um erro ao excluir o equipamento"));
}

include "../config/connection.php";

$clean_equipment_id = mysqli_escape_string($connection, $equipment_id);
$query = "UPDATE equipamentos SET ativo = '0' WHERE id_equipamento = '$clean_equipment_id'";
mysqli_query($connection, $query) or die(mysqli_connect_error());

return print json_encode(new Response("success", "ok"));

mysqli_close($connection);

?>
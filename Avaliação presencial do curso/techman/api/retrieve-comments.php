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
  return print json_encode(new Response("error", "Houve um erro ao acessar os comentários"));
}

include "../config/connection.php";

$clean_equipment_id = mysqli_escape_string($connection, $equipment_id);
$query = "SELECT comentario, comentarios.data AS data, perfil FROM `comentarios` JOIN equipamentos ON equipamentos.id_equipamento = comentarios.fk_id_equipamento JOIN perfis ON perfis.id_perfil = comentarios.fk_id_perfil WHERE fk_id_equipamento = '$clean_equipment_id' ORDER BY data DESC";
$result = mysqli_query($connection, $query) or die(mysqli_connect_error());
$data = mysqli_fetch_all($result, MYSQLI_ASSOC);

return print json_encode(new Response("success", $data));

mysqli_close($connection);

?>
<?php
include '../config/connection.php';

// Fetch Sellers
$res = mysqli_query($conn, "SELECT nome, vendedores.id AS id FROM pessoa INNER JOIN vendedores ON pessoa.id = vendedores.pessoa_id");
if (mysqli_num_rows($res) > 0) {
  $sellers = mysqli_fetch_all($res, MYSQLI_ASSOC);
}

// Fetch Clients
$res = mysqli_query($conn, "SELECT nome, clientes.id AS id FROM pessoa INNER JOIN clientes ON pessoa.id = clientes.pessoa_id");
if (mysqli_num_rows($res) > 0) {
  $clients = mysqli_fetch_all($res, MYSQLI_ASSOC);
}

// Fetch Products
$res = mysqli_query($conn, "SELECT descricao, id AS id FROM produtos");
if (mysqli_num_rows($res) > 0) {
  $products = mysqli_fetch_all($res, MYSQLI_ASSOC);
}

mysqli_close($conn);
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
  <?php include '../config/head.php'; ?>
  <link rel="stylesheet" href="../styles/main.css">
</head>
<body>
  <?php include '../templates/navbar.php'; ?>
  <main>
    <header>
      <i class="material-icons large">add_shopping_cart</i>
      <h2>Cadastrar pedido</h2>
    </header>
    <form action="<?php echo $_SERVER['PHP_SELF']; ?>">
      <label id="client">Cliente</label>
      <select name="client" class="browser-default" id="client" required>
        <option selected disabled>Selecione o cliente</option>
        <?php foreach ($clients as $client) { ?>
          <option value="<?php echo $client['id']; ?>"><?php echo $client['nome']; ?></option>
        <?php } ?>
      </select>
      <label id="seller">Vendedor</label>
      <select name="seller" class="browser-default" id="seller" required>
        <option selected disabled>Selecione o vendedor</option>
        <?php foreach ($sellers as $seller) { ?>
          <option value="<?php echo $seller['id']; ?>"><?php echo $seller['nome']; ?></option>
        <?php } ?>
      </select>
      <div class="input-field">
        <input type="number" min="0" name="valor" id="valor" required>
        <label for="valor">Valor</label>
      </div>
      <label class="status">Status</label>
      <ul class="radios">
        <li>
          <label>
            <input type="radio" name="status" id="ativo" class="with-gap">
            <span>Ativo</span>
        </label>
        </li>
        <li>
          <label>
            <input type="radio" name="status" id="inativo" class="with-gap">
            <span>Inativo</span>
          </label>
        </li>
      </ul>
      <select name="product" class="browser-default" id="product" required>
        <option selected disabled>Adicionar produto</option>
        <?php foreach ($clients as $client) { ?>
          <option value="<?php echo $client['id']; ?>"><?php echo $client['nome']; ?></option>
        <?php } ?>
      </select>
    </form>
  </main>
</body>
</html>
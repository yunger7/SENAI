<?php
$currentFile = basename($_SERVER['PHP_SELF']);
$dirName = dirname($_SERVER['PHP_SELF']);
?>

<?php if ($dirName == "/avaliacao-final/cliente") { /* Client section */ ?>
  <nav>
    <div class="nav-wrapper">
      <a href="#" class="brand-logo right">Logo</a>
      <ul class="left">
        <li class="<?php if ($currentFile == "index.php") { echo "active"; } ?>"><a href="index.php">Pedidos</a></li>
        <li class="<?php if ($currentFile == "search.php" || $currentFile == "searchResults.php") { echo "active"; } ?>"><a href="search.php">Pesquisar</a></li>
      </ul>
    </div>
  </nav>
<?php } else if ($dirName == "/avaliacao-final/vendedor") { /* Seller section */ ?>
  <nav>
    <div class="nav-wrapper">
      <a href="#" class="brand-logo right">Logo</a>
      <ul class="left">
        <li class="<?php if ($currentFile == "index.php") { echo "active"; } ?>"><a href="index.php">Clientes</a></li>
        <li class="<?php if ($currentFile == "orders.php") { echo "active"; } ?>"><a href="orders.php">Pedidos</a></li>
      </ul>
    </div>
  </nav>
<?php } ?>
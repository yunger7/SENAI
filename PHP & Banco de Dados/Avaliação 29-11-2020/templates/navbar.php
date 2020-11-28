<?php
$currentFile = basename($_SERVER['PHP_SELF']);
?>

<nav>
  <div class="nav-wrapper">
    <a href="#" class="brand-logo right">Logo</a>
    <ul class="left hide-on-med-and-down">
      <li class="<?php if ($currentFile == "index.php") { echo "active"; } ?>"><a href="index.php">Clientes</a></li>
      <li class="<?php if ($currentFile == "orders.php") { echo "active"; } ?>"><a href="orders.php">Pedidos</a></li>
    </ul>
  </div>
</nav>
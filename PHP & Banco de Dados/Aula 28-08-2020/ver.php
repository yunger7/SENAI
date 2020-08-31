<?php
  include("conecta.php");

  $sql = mysqli_query($conn, "SELECT * FROM teste ORDER BY nome") or die(mysqli_error($conn));
  echo "<table border=1>";
  echo "<tr>";
  echo "<th>Nome</th>";
  echo "<th>Idade</th>";
  echo "</tr>";

  while($cliente = mysqli_fetch_array($sql)){
    echo "<tr>";
    echo "<td>" . $cliente['nome'] . "</td>";
    echo "<td>" . $cliente['idade'] . "</td>";
    echo "</tr>";
  }
  echo "</table>";

  mysqli_close($conn);

  echo "<hr/>";
  echo "<a href='minicad.php'>Voltar para o cadastro</a>";
?>
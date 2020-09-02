<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>CRUD-  PHP</title>
</head>
<body>
  <h4>Crud básico em PHP</h4>
  <hr>
  <?php
    include("conecta.php");

    $id = $_GET['id'];
    $sql = mysqli_query($conn, "SELECT * FROM teste WHERE id = $id") or die (mysqli_error($conn));

    while($cliente = mysqli_fetch_array($sql)){;
  ?>
  <form action="editadb.php?id=<?php echo $id; ?>" method="POST">
    <label>Insira o seu nome: <input type="text" name="nome" value="<?php echo $cliente['nome']; ?>"></label>
    <br><br>
    <label>Insira sua idade: <input type="number" name="idade" value="<?php echo $cliente['idade']; ?>"></label>
    <br><br>
    <button type="submit">Atualizar</button>
  </form>
  <?php
    }
    mysqli_close($conn);
  ?>
  <hr>
  <?php
    include 'conecta.php';

    echo '<h4>Pessoas cadastradas</h4>';
    $sql = mysqli_query($conn, "SELECT * FROM teste ORDER BY nome") or die(mysqli_error($conn));

    echo "<table border=1>";
    echo "<tr>";
      echo "<th>Nome</th>";
      echo "<th>Idade</th>";
      echo "<th>Ações</th>";
    echo "</tr>";

    while($pessoa = mysqli_fetch_array($sql)){
      echo "<tr>";
        $id = $pessoa['id'];
        echo "<td>".$pessoa['nome'] . "</td>";
        echo "<td>" . $pessoa['idade'] ."</td>";
        echo "<td><a href='edita.php?id=$id'><button type='submit'>Edita</button></a> | <a href='exclui.php?id=$id'><button type='submit'>Exclui</button></a></td>";
      echo "</tr>";
    }
    echo "</table>";
    mysqli_close($conn);
    echo "<hr/>"
  ?>
</body>
</html>
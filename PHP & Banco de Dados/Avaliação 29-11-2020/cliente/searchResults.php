<?php
if (isset($_POST['submit-search'])) {
  include '../config/connection.php';
  $sql = "SELECT * FROM produtos";

  $cases = [
    'descricao' => $_POST['descricao'] ?? '',
    'estoque' => $_POST['estoque'] ?? '',
    'valor' => $_POST['valor'] ?? '',
    'status' => $_POST['status'] ?? ''
  ];

  $caseNumbers = 0;
  foreach ($cases as $case) {
    if ($case !== '') {
      $caseExists = 1;
      $caseNumbers += 1;
    }
  }

  if (isset($caseExists)) {
    $sql = $sql . " WHERE ";
  }
  
  foreach ($cases as $caseName => $caseValue) {
    if ($caseValue !== "") {
      $sql = $sql . "($caseName IS NULL OR $caseName LIKE '%$caseValue%')";
      $caseNumbers -= 1;

      if ($caseNumbers >= 1) {
        $sql = $sql . " AND ";
      }
    }
  }

  $res = mysqli_query($conn, $sql);
  if (mysqli_num_rows($res) > 0) {
    $products = mysqli_fetch_all($res, MYSQLI_ASSOC);
    $searchResult = 1;
    mysqli_free_result($res);
  } else {
    $searchResult = 0;
  }

  mysqli_close($conn);
}
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
    <?php if ($searchResult == 0) { ?>
      <h4 class="center">Não houveram resultados para sua busca</h4>
    <?php } else if ($searchResult == 1) { ?>
      <table class="highlight centered responsive-table">
        <thead>
          <tr>
            <th>Descrição</th>
            <th>Estoque</th>
            <th>Valor</th>
            <th>Status</th>
          </tr>
        </thead>

        <tbody>
          <?php foreach ($products as $product) { ?>
            <tr>
              <td><?php echo $product['descricao']; ?></td>
              <td><?php echo $product['estoque']; ?></td>
              <td><?php echo $product['valor']; ?></td>
              <td><?php echo $product['status']; ?></td>
            </tr>
          <?php } ?>
        </tbody>
      </table>
    <?php } ?>
  </main>
</body>
</html>

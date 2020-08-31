<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Cadastro - Inserindo em DB</title>
</head>
<body>
  <form action="cadpessoa.php" method="POST">
    <label>Insira o seu nome: <input type="text" name="nome" id="nome"></label>
    <br><br>
    <label>Insira sua idade: <input type="number" name="idade" id="idade"></label>
    <br><br>
    <button type="submit">Cadastrar</button>
  </form>
  <hr>
  <a href="ver.php">Ver pessoas cadastradas</a>
</body>
</html>
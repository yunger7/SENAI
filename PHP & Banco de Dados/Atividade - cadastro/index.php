<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Sistema de cadastro</title>

  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
  <link rel="stylesheet" href="index.css">
</head>

<body>
  <h1>Cadastro</h1>
  <form action="cadastro-ok.php" method="POST">
    <label for="nome">Nome: </label>
    <input type="text" name="nome" id="nome" placeholder="Digite seu nome" required>
    <label for="celular">Celular: </label>
    <input type="tel" name="celular" id="celular" placeholder="Digite seu celular" required>
    <label for="email">Email: </label>
    <input type="email" name="email" id="email" placeholder="Digite seu email" required>
    <button type="submit" class="btn btn-primary">Cadastrar</button>
  </form>
</body>

</html>
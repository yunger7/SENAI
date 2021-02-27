<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Agenda</title>

  <link rel="shortcut icon" href="images/agenda.svg" type="image/x-icon">
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>

<body>
  <header>
    <div>
      <h4>Agenda 2.0 - TDS - SENAI</h4>
      <hr>
    </div>
  </header>
  <nav>
    <hr>
  </nav>
  <section>
    <center>
      <div style="width: 500px; height: 280px; background-color: rgba(0,0,255,0.1);">
        <form action="login.php" method="POST">
          <fieldset>
            <legend>Login</legend>
            <label for="login">Login</label>
            <input type="text" name="login" id="login" class="form-control" required>
            <br>
            <label for="senha">Senha</label>
            <input type="password" name="senha" id="senha" class="form-control" required>
            <br>
            <button type="submit" class="btn btn-outline-success">Entrar</button>
          </fieldset>
        </form>
      </div>
    </center>
  </section>
  <footer>
    <hr>
    <div>Agenda 2.0 Desenvolvido em Aula - Versão 1.0</div>
  </footer>
</body>

</html>
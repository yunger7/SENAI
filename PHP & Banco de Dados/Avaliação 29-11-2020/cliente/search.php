<!DOCTYPE html>
<html lang="pt-br">
<head>
  <?php include '../config/head.php'; ?>
  <link rel="stylesheet" href="../styles/main.css">
  <link rel="stylesheet" href="../styles/pages/cliente/search.css">
</head>
<body>
  <?php include '../templates/navbar.php'; ?>
  <main>
    <section id="search">
      <header>
        <i class="material-icons large search">search</i>
        <h2>Pesquisar Produtos</h2>
      </header>
      <form action="searchResults.php" method="POST">
        <div class="input-field">
          <input type="text" name="descricao" id="descricao">
          <label for="descricao">Descrição</label>
        </div>
        <div class="input-field">
          <input type="number" min="0" name="estoque" id="estoque">
          <label for="estoque">Estoque</label>
        </div>
        <div class="input-field">
          <input type="number" min="0" name="valor" id="valor">
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
        <div class="buttons">
          <button class="btn waves-effect waves-light" type="submit" name="submit-search">Pesquisar
            <i class="material-icons right">send</i>
          </button>
        </div>
      </form>
    </section>
  </main>
</body>
</html>
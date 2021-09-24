<?php
  session_start();

  if (isset($_SESSION) && isset($_SESSION["status"])) {
    if ($_SESSION["status"] == "ok") {
      header('Location: ./equipamentos.php');
    }
  }
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
  <?php include "./components/head.php"; ?>
  <link rel="stylesheet" href="./lib/toastify/toastify.css" />

  <link rel="stylesheet" href="./static/styles/login.css" />
  <title>Login | Techman</title>
</head>
<body>
  <img class="logo" src="/techman/static/images/techman.png" alt="Techman logo" />
  <div class="panel">
    <div class="display"></div>
    <div class="numpad">
      <button class="digit">1</button>
      <button class="digit">2</button>
      <button class="digit">3</button>
      <button class="digit">4</button>
      <button class="digit">5</button>
      <button class="digit">6</button>
      <button class="digit">7</button>
      <button class="digit">8</button>
      <button class="digit">9</button>
      <button class="clear">C</button>
      <button class="digit">0</button>
      <button class="enter" disabled>
        <svg class="enter-icon" height="48" id="svg8" version="1.1" viewBox="0 0 12.7 12.7" width="48" xmlns="http://www.w3.org/2000/svg" xmlns:cc="http://creativecommons.org/ns#" xmlns:dc="http://purl.org/dc/elements/1.1/" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:svg="http://www.w3.org/2000/svg"><g id="layer1" transform="translate(0,-284.29998)"><path d="m 9.8777781,289.9444 3e-7,-2.82221 H 8.4666671 v 2.82221 c 0,0.3528 -0.3527779,0.70558 -0.7055555,0.70558 H 4.2333335 l 2.1166668,-2.11667 -0.7055467,-0.70557 -3.5277868,3.52778 3.5277868,3.52779 0.7055467,-0.70557 -2.1166668,-2.11667 h 3.5277781 c 1.2347222,0 2.1166665,-0.88195 2.1166665,-2.11667 z" id="path4483" style="fill-opacity:1;fill-rule:evenodd;stroke:none;stroke-width:0.70555556px;stroke-linecap:butt;stroke-linejoin:miter;stroke-opacity:1"/></g></svg>
      </button>
    </div>
  </div>
  <div id="toast"></div>
  <script src="./lib/toastify/toastify.js"></script>
  <script src="./static/scripts/login.js"></script>
</body>
</html>
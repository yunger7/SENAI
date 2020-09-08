<?php
  // iniciar um sessão
  session_start();
  include('conecta.php');
  $login = $_POST['login'];
  $senha = $_POST['senha'];

  $sql = "SELECT * FROM usuario WHERE login = '$login' AND senha = '$senha'";
  $logar = mysqli_query($conn, $sql) or die(mysqli_connect_error());

  if(mysqli_num_rows($logar) > 0){
    // existe no banco
    $_SESSION['user'] = $_POST['login'];

    echo "
    <script language='javascript' type='text/javascript'>
    location.href = 'agenda.php';
    </script>
    ";
  } else {
    echo "
    <script language='javascript' type='text/javascript'>
    alert('Login ou senha incorretos! Tente novamente!');
    location.href = 'index.php';
    </script>
    ";
  }
?>
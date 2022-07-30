<?php
	$host = "localhost";
	$user = "root";
	$pass = "usbw";
	$banco = "bdescolar";

	$conn = new mysqli ($host, $user, $pass, $banco);
	if ($conn->connect_error){
	die ("Falha na conexão: ". $conn->connect_error);
}
  ?>
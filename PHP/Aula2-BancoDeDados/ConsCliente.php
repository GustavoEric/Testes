<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Consulta do Cliente</title>
</head>
<body>
	<?php
	require_once('conn.php');
	$sql=mysqli_query($conn,"SELECT * FROM tbcliente");

	while ($linha=mysqli_fetch_array($sql)){
		$cod=$linha['CodCliente'];
		$nome=$linha['NomeCliente'];
		$Ende = $linha['EnderecoCliente'];
		$Cep = $linha['CepCliente'];
		$Tel = $linha['TelCliente'];
		$Cel = $linha['CelCliente'];
		$Email = $linha['EmailCliente'];
		echo "<table border = 1><tr><td>Código do Cliente:</td><td>$cod</td></tr>";
		echo "<tr><td>Nome do Cliente: </td><td>$nome</td></tr>";
		echo "<tr><td>Endereço do Cliente:</td><td>$Ende</td></tr>";
		echo "<tr><td>CEP do Cliente:</td><td>$Cep</td></tr>";
		echo "<tr><td>Telefone do Cliente: </td><td>$Tel</td></tr>";
		echo "<tr><td>Celular do Cliente:</td><td>$Cel</td></tr>";
		echo "<tr><td>Email do Cliente: </td><td>$Email</td></tr></table><br><br>";
	}

	 ?>
</body>
</html>
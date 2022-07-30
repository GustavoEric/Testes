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
	$sql=mysqli_query($conn,"SELECT * FROM tbvendedor");

	while ($linha=mysqli_fetch_array($sql)){
		$cod=$linha['CodVendedor'];
		$nome=$linha['NomeVendedor'];
		$Tel = $linha['TelVendedor'];
		$Cel = $linha['CelVendedor'];
		$Email = $linha['EmailVendedor'];
		echo "<table border = 1><tr><td>Código do Vendedor:</td><td>$cod</td></tr>";
		echo "<tr><td>Nome do Vendedor: </td><td>$nome</td></tr>";
		echo "<tr><td>Telefone do Vendedor: </td><td>$Tel</td></tr>";
		echo "<tr><td>Celular do Vendedor:</td><td>$Cel</td></tr>";
		echo "<tr><td>Email do Vendedor: </td><td>$Email</td></tr></table><br><br>";
	}

	 ?>
</body>
</html>
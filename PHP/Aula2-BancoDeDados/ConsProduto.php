<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Consulta do Produto</title>
</head>
<body>
	<?php
	require_once('conn.php');
	$sql=mysqli_query($conn,"SELECT * FROM tbproduto");

	while ($linha=mysqli_fetch_array($sql)){
		$nome=$linha['NomeProduto'];
		$QTD = $linha['QtdeEstoque'];
		$Preco = $linha['PrecoProduto'];
		echo "<table border =1><tr><td>Nome do Produto: </td><td>$nome</td></tr>";
		echo "<tr><td>Quantidade de Produtos:</td><td>$QTD</td></tr>";
		echo "<tr><td>Preço: </td><td>$Preco</td></tr></table><br><br>";
	}

	 ?>
</body>
</html>
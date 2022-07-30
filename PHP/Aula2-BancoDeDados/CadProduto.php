<!DOCTYPE html>
<html>
<head>
	<title>Cadastro Produto</title>
	<meta charset="utf-8">
</head>
<body>
	<form action="CadastraProduto.php" method="POST">
		<table border="1">
			<tr>
				<td><label>Digite o Nome do Produto</label></td>
				<td><input type="text" name="txtNProduto"></td>
				<td><label>Digite a Quantidade de Estoque</label></td>
				<td><input type="text" name="txtQTD"></td>
				<td><label>Digite o Preço</label></td>
				<td><input type="text" name="txtPreco"></td>
				<td><input type="submit" name="Enviar"></td>
			</tr>
		</table>
	</form>
</body>
</html>
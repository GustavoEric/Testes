<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Cadastro Cliente</title>
</head>
<body>
	<form action="CadastraCliente.php" method="post">
		<table border="1">
		<tr>
		<td><label>Digite seu Nome:</label></td>
		<td><input type="text" name="txtNome"></td>
		<td><label>Digite seu Endereço:</label></td>
		<td><input type="text" name="txtEnde"></td>
		<td><label>Digite seu CEP:</label></td>
		<td><input type="text" name="txtCEP"></td>
		</tr>
		<tr>
		<td><label>Digite seu Telefone:</label></td>
		<td><input type="text" name="txtTEL"></td>
		<td><label>Digite seu Celular:</label></td>
		<td><input type="text" name="txtCEL"></td>
		<td><label>Digite seu Email:</label></td>
		<td><input type="text" name="txtEmail"></td>
		<td><input type="submit" name="Cadastrar"></td>
		</tr>
		</table>
	</form>

</body>
</html>
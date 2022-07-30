<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio5</title>
</head>
<body>
	<form action="Exercicio5.php" method="POST">
		<center>
		<table border="1">
			<tr>
				<td><label>Digite O Seu Nome</label></td>
				<td><label>Digite O Nome do Livro</label></td>
				<td><label>Selecione Seu Genero</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtNome"></td>
				<td><input type="text" name="txtLivro"></td>
				<td><select name="Categoria">
					<option value="prof">Professor</option>
					<option value="alu">Aluno</option>
				</select></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Nome=$_POST['txtNome'];
			$Livro=$_POST['txtLivro'];
			$Categoria=$_POST['Categoria'];

			if ($Categoria=="prof"){
				echo "<center>$Nome você tem 10 dias para devolver o livro $Livro </center>";
			}

			else if ($Categoria=="alu"){
				echo "<center>$Nome você tem 3 dias para devolver o livro $Livro </center>";
			}

		?>

</body>
</html>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio6</title>
</head>
<body>
	<form action="Exercicio6.php" method="POST">
		<center>
		<table border="1">
			<tr>
				<td><label>Digite o Comprimento</label></td>
				<td><label>Digite a Altura</label></td>
				<td><label>Digite a Largura</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtComprimento"></td>
				<td><input type="text" name="txtAltura"></td>
				<td><input type="text" name="txtLargura"></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Com=$_POST['txtAltura'];
			$Alt=$_POST['txtAltura'];
			$Lar=$_POST['txtLargura'];

			$volume=$Com*$Lar*$Alt;

				echo "<center>O Volume da Sua caixa é: $volume</center>";

		?>

</body>
</html>
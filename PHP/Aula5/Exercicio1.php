<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio1</title>
</head>
<body>
	<form action="Exercicio1.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Digite Sua Altura</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtAltura"></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Altura=$_POST['txtAltura'];

			$Peso=(72.7*$Altura)-58;

			echo "<center>Seu Peso Ideal é $Peso Kg</center>";

		?>

</body>
</html>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio7</title>
</head>
<body>
	<form action="Exercicio7.php" method="POST">
		<center>
		<table border="1">
			<tr>
				<td><label>Distância total (em km) </label></td>
				<td><label>Quantidade de combustível (em litros) </label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtKm"></td>
				<td><input type="text" name="txtCm"></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Km=$_POST['txtKm'];
			$Cm=$_POST['txtCm'];

			$Consumo=$Km/$Cm;

				echo "<center>Seu Consumo Médio durante a viagem foi: $Consumo</center>";

		?>

</body>
</html>
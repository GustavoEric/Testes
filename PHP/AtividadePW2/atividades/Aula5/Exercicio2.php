<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio2</title>
</head>
<body>
	<form action="Exercicio2.php" method="POST">
		<center>
		<table border="1">
			<tr>
				<td><label>Digite Sua Altura</label></td>
				<td><label>Selecione Seu Genero</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtAltura"></td>
				<td><select name="Genero">
					<option value="Mas">Masculino</option>
					<option value="Fem">Feminino</option>
				</select></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Altura=$_POST['txtAltura'];
			$Genero=$_POST['Genero'];

			if ($Genero=="Mas"){
				$Peso=(72.7*$Altura)-58;
			}

			else if ($Genero=="Fem"){
				$Peso=(62.1*$Altura)-44.7;
			}
			echo "<center>Seu Peso Ideal é $Peso Kg</center>";

		?>

</body>
</html>
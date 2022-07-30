<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio4</title>
</head>
<body>
	<form action="Exercicio4.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Digite Um Número de 1 a 12</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtMes"></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$Mes=$_POST['txtMes'];

			if ($Mes==1){
			echo "<center>Mês Igual a Janeiro</center>";
			}
			else if ($Mes==2){
			echo "<center>Mês Igual a Fevereiro</center>";
			}
			else if ($Mes==3){
			echo "<center>Mês Igual Março</center>";
			}
			else if ($Mes==4){
			echo "<center>Mês Igual a Abril</center>";
			}
			else if ($Mes==5){
			echo "<center>Mês Igual a Maio</center>";
			}
			else if ($Mes==6){
			echo "<center>Mês Igual a Junho</center>";
			}
			else if ($Mes==7){
			echo "<center>Mês Igual a Julho</center>";
			}
			else if ($Mes==8){
			echo "<center>Mês Igual a Agosto</center>";
			}
			else if ($Mes==9){
			echo "<center>Mês Igual a Setembro</center>";
			}
			else if ($Mes==10){
			echo "<center>Mês Igual a Outubro</center>";
			}
			else if ($Mes==11){
			echo "<center>Mês Igual a Novembro</center>";
			}
			else if ($Mes==12){
			echo "<center>Mês Igual a Dezembro</center>";
			}
			else{
				echo "<center>Número de Mês Inválido</center>";
			}

		?>

</body>
</html>
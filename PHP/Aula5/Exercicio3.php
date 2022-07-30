<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio3</title>
</head>
<body>
	<form action="Exercicio3.php" method="POST">
		<center>
		<table border="1">
			<tr>
				<td><label>Digite Numero 1</label></td>
				<td><label>Digite Numero 2</label></td>
				<td><label>Selecione Seu Genero</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtn1"></td>
				<td><input type="text" name="txtn2"></td>
				<td><select name="Calculo">
					<option value="Soma">Adição</option>
					<option value="Sub">Subtração</option>
					<option value="Mul">Multiplicação</option>
					<option value="Div">Divisão</option>
				</select></td>
				<td><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
		<?php  
			$n1=$_POST['txtn1'];
			$n2=$_POST['txtn2'];
			$Calculo=$_POST['Calculo'];

			if ($Calculo=="Soma"){
				$Resultado=$n1+$n2;
			}

			else if ($Calculo=="Sub"){
				$Resultado=$n1-$n2;
			}
			else if ($Calculo=="Mul"){
				$Resultado=$n1*$n2;
			}
			else if ($Calculo=="Div"){
				$Resultado=$n1/$n2;
			}
			echo "<center>O Resultado é $Resultado</center>";

		?>

</body>
</html>
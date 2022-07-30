<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Temperatura</title>
</head>
<body>
	<form action="Temperatura.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Conversão de</label></td>
			<td><label>Para</label>
			<td><label>Digite a Temperatura</label></td>
			</tr>
			<tr>
				<td>
					<select name="Op1">
						<option value="CEL1">Celsius</option>
						<option value="FAH1">Fahrenheit</option>
						<option value="KEL1">Kelvin</option>
					</select>
				</td>

				<td>
					<select name="Op2">
						<option value="CEL2">Celsius</option>
						<option value="FAH2">Fahrenheit</option>
						<option value="KEL2">Kelvin</option>
						<option value="RAN2">Rankine</option>
						<option value="REA2">Réaumur</option>
					</select>
				</td>
				<td>
					<input type="text" name="txtTemp">
				</td>
				<td >
					<input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>

	<?php 
 		$Opcao1=$_POST['Op1'];
 		$Opcao2=$_POST['Op2'];
 		$Temperatura=$_POST['txtTemp'];

 		if (($Opcao1=="CEL1")&&($Opcao2=="FAH2")){
 			$Resultado=($Temperatura*1.8)+32;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if (($Opcao1=="CEL1")&&($Opcao2=="KEL2")){
 			$Resultado=$Temperatura+273.15;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="CEL1")&&($Opcao2=="RAN2")){
 			$Resultado=($Temperatura*1.8)+32+459.67;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="CEL1")&&($Opcao2=="REA2")){
 			$Resultado=$Temperatura*0.8;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="KEL1")&&($Opcao2=="CEL2")){
 			$Resultado=$Temperatura-273.15;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="KEL1")&&($Opcao2=="FAH2")){
 			$Resultado=($Temperatura*1.8)-459.67;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="KEL1")&&($Opcao2=="CEL2")){
 			$Resultado=$Temperatura-273.15;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="KEL1")&&($Opcao2=="RAN2")){
 			$Resultado=$Temperatura*1.8;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="KEL1")&&($Opcao2=="REA2")){
 			$Resultado=($Temperatura-273.15)*0.8;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="FAH1")&&($Opcao2=="CEL2")){
 			$Resultado=($Temperatura-32)*1.8;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="FAH1")&&($Opcao2=="KEL2")){
 			$Resultado=($Temperatura+459.67)/1.8;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="FAH1")&&($Opcao2=="RAN2")){
 			$Resultado=$Temperatura+459.67;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else if (($Opcao1=="FAH1")&&($Opcao2=="REA2")){
 			$Resultado=($Temperatura-32)/2.25;
 			echo "<center>
 				<table border =1>
 					<tr>
 					<td><label>Sua Conversão é</label></td>

 					</tr>
 					<tr>
 						<td>$Resultado</td>
 					</tr>
 				</table>
 				</center>";
		}
		else{
			echo "Opcão Inválida";
		}
	 ?>


</body>
</html>
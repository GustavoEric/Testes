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
			<td><label>Converter Para</label></td>
			<td><label>Valor Em Reais</label>
			</tr>
			<tr>
				<td>
					<select name="Op1">
						<option value="DOL">Dolar</option>
						<option value="EUR">Euro</option>
						<option value="LIB">Libras</option>
					</select>
				</td>
					<td><input type="text" name="txtVAL"></td>
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
 		$Reais=$_POST['txtVAL'];

 		if ($Opcao1=="DOL") {
 			$Conversao=$Reais/5.40;
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Valor Digitado</label></td>
 						<td><label>Valor Da Cotação</label></td>
 					</tr>
 					<tr>
 						<td>$Reais</td>
 						 <td>$Conversao</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if ($Opcao1=="EUR") {
 			$Conversao=$Reais/6.50;
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Valor Digitado</label></td>
 						<td><label>Valor Da Cotação</label></td>
 					</tr>
 					<tr>
 						<td>$Reais</td>
 						 <td>$Conversao</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if ($Opcao1=="LIB") {
 			$Conversao=$Reais/7.00;
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Valor Digitado</label></td>
 						<td><label>Valor Da Cotação</label></td>
 					</tr>
 					<tr>
 						<td>$Reais</td>
 						 <td>$Conversao</td>
 					</tr>
 				</table>
 				</center>";
 		}
 	?>
 </body>
</html>

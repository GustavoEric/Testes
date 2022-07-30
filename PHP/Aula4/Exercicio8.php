<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio8</title>
</head>
<body>
	<form action="Exercicio8.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Quantidade da Colheita (KG)</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtCO"></td>
				<td >
					<input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
	<?php 
 		$colheita=$_POST['txtCO'];

 		if ($colheita<=1000){
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Situação de Colheita</label></td>
 					</tr>
 					<tr>
 						 <td>Abaixo da Meta</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if (($colheita>1000)&&($colheita<5000)){
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Situação de Colheita</label></td>
 					</tr>
 					<tr>
 						 <td>Dentro da Meta</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else{
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Situação de Colheita</label></td>
 					</tr>
 					<tr>
 						 <td>Acima da Meta</td>
 					</tr>
 				</table>
 				</center>";
 		}
 	?>
 </body>
</html>
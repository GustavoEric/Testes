<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio9</title>
</head>
<body>
	<form action="Exercicio9.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Quantidade de Alunos Matriculados</label></td>
			<td><label>Quantidade de Alunos Formados</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtAM"></td>
				<td><input type="text" name="txtAF"></td>
					<input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
	<?php 
 		$Am=$_POST['txtAM'];
 		$Af=$_POST['txtAF'];

 		$Ev=($Am*$Af)/100;

 		if ($Ev<10){
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Porcentagem</label></td>
 						<td><label>Situação</label></td>
 					</tr>
 					<tr>
 						 <td>$Ev %</td>
 						 <td>Baixa Evasão</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if (($Ev>=10)&&($Ev<15)){
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Porcentagem</label></td>
 						<td><label>Situação</label></td>
 					</tr>
 					<tr>
 						 <td>$Ev %</td>
 						 <td>Evasão média</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else if (($Ev>=15)&&($Ev<25)){
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Porcentagem</label></td>
 						<td><label>Situação</label></td>
 					</tr>
 					<tr>
 						 <td>$Ev %</td>
 						 <td>Evasão alta</td>
 					</tr>
 				</table>
 				</center>";
 		}
 		else{
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Porcentagem</label></td>
 						<td><label>Situação</label></td>
 					</tr>
 					<tr>
 						 <td>$Ev %</td>
 						 <td>Evasão muito Alta</td>
 					</tr>
 				</table>
 				</center>";
 		}
 	?>
 </body>
</html>
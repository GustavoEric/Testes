<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio10</title>
</head>
<body>
	<form action="Exercicio10.php" method="POST">
		<center>
		<table border="1">
			<tr>
			<td><label>Valor arrecadado com as inscrições</label></td>
			<td><label>Quantidade de fiscais</label></td>
			<td><label>Valor gasto com alimentação</label></td>
			</tr>
			<tr>
				<td><input type="text" name="txtIns"></td>
				<td><input type="text" name="txtFis"></td>
				<td><input type="text" name="txtAlm"></td>
			</tr>
			<tr>
				<td colspan="3"><input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
	<?php 
 		$Inscricao=$_POST['txtIns'];
 		$Fiscal=$_POST['txtFis'];
 		$Alimentacao=$_POST['txtAlm'];

 		if (isset($_POST['btnCalcular'])){
 		$Total=($Inscricao-$Fiscal*70)-$Alimentacao;
 		$Despesas=$Inscricao-$Total;

 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Valor Total Arrecadado</label></td>
 						<td><label>Despesas</label></td>
 					</tr>
 					<tr>
 						 <td>$Total</td>
 						 <td>$Despesas</td>
 					</tr>
 				</table>
 				</center>";
 		}
 	?>
 </body>
</html>
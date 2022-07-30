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
			<td><label>Nota do Trabalho</label></td>
			<td><label>Nota da Prova</label>
			</tr>
			<tr>
				<td><input type="text" name="txtTRA"></td>
				<td><input type="text" name="txtPRO"></td>
				<td >
					<input type="submit" name="btnCalcular" value="Enviar">
				</td>
			</tr>
		</table>
		</center>
	</form>
	<?php 
 		$prova=$_POST['txtPRO'];
 		$trabalho=$_POST['txtTRA'];

 		if (($prova>10)||($trabalho>10)) {
 			echo "Por Favor Digite as Notas do Trabalho e da Prova de 0 a 10";
 		}
 		else if (($prova<0)||($trabalho<0)) {
 			echo "Por Favor Digite as Notas do Trabalho e da Prova de 0 a 10";
 		}
 		else{
 		$nota=($trabalho*4+$prova*6)/10;
 			echo "<center>
 				<table border =1>
 					<tr>
 						<td><label>Nota Geral</label></td>
 					</tr>
 					<tr>
 						 <td>$nota</td>
 					</tr>
 				</table>
 				</center>";
 		}
 	?>
 </body>
</html>
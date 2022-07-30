<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio6</title>
</head>
<body>
	<form action="Exercicio6.php" method="post">
		<table>
			<tr>
				<td><label>Digite Meses Trabalhados</label></td>
				<td><input type="txt" name="txtnum1"></td>
				<td><input type="submit" name="enviar"></td>
			</tr>
		</table>
	</form>

	<?php 
		$meses=$_POST['txtnum1'];


		if ($meses<6){
			echo "Não Tem Direito";
		}
		else if (($meses>=6)&&($meses<12)){
			echo "3 Parcelas";
		}
		else if (($meses>11)&&($meses<25)){
			echo "4 Parcelas";
		}
		else if ($meses>24){
			echo "5 Parcelas";
		}
		else{
			echo "Digite Os Meses Trabalhados";
		}
	 ?>

</body>
</html>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio4</title>
</head>
<body>
	<form action="Exercicio4.php" method="post">
		<table>
			<tr>
				<td><label>Digite Número 1</label></td>
				<td><input type="txt" name="txtnum1"></td>
				<td><label>Digite Número 2</label></td>
				<td><input type="txt" name="txtnum2"></td>
				<td><input type="submit" name="enviar"></td>
			</tr>
		</table>
	</form>

	<?php 
		$n1=$_POST['txtnum1'];
		$n2=$_POST['txtnum2'];

		$soma=$n1+$n2;

		if ($soma>20){
			$soma+=8;
			echo "Maior que 20: $soma";
		}
		else if ($media<=20){
			$soma-=5;
			echo "Menor ou Igual a 20: $soma";
		}
		else{
			echo "Digite As Dois Números";
		}
	 ?>

</body>
</html>
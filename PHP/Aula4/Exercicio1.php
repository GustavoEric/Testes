<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio1</title>
</head>
<body>
	<form action="Exercicio1.php" method="post">
		<table>
			<tr>
				<td><label>Digite Numero 1</label></td>
				<td><input type="txt" name="txtnum1"></td>
				<td><label>Digite Numero 2</label></td>
				<td><input type="txt" name="txtnum2"></td>
				<td><label>Digite Numero 3</label></td>
				<td><input type="txt" name="txtnum3"></td>
				<td><input type="submit" name="enviar"></td>
			</tr>
		</table>
	</form>

	<?php 
		$num1=$_POST['txtnum1'];
		$num2=$_POST['txtnum2'];
		$num3=$_POST['txtnum3'];

		if (($num1>$num2)&&($num1>$num3)){
			echo "O maior Numero é: $num1";
		}
		else if (($num2>$num1)&&($num2>$num3)){
			echo "O maior Numero é: $num2";
		}
		else{
			echo "O maior Numero é: $num3";
		}
	 ?>
</body>
</html>
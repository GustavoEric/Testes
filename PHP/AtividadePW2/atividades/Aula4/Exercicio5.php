<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio5</title>
</head>
<body>
	<form action="Exercicio5.php" method="post">
		<table>
			<tr>
				<td><label>Digite Base maior do Trapézio</label></td>
				<td><input type="txt" name="txtnum1"></td>
				<td><label>Digite Base menor do Trapézio</label></td>
				<td><input type="txt" name="txtnum2"></td>
				<td><label>Digite Altura do Trapézio</label></td>
				<td><input type="txt" name="txtnum3"></td>
				<td><input type="submit" name="enviar"></td>
			</tr>
		</table>
	</form>

	<?php 
		$B=$_POST['txtnum1'];
		$b=$_POST['txtnum2'];
		$Altura=$_POST['txtnum3'];

		$Area=(($B+$b)*$Altura)/2;

		echo "A Área do Trapézio é $Area";
	 ?>

</body>
</html>
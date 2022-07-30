<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exercicio2</title>
</head>
<body>
	<form action="Exercicio2.php" method="post">
		<table>
			<tr>
				<td><label>Digite Nota 1</label></td>
				<td><input type="txt" name="txtnum1"></td>
				<td><label>Digite Nota 2</label></td>
				<td><input type="txt" name="txtnum2"></td>
				<td><label>Digite Nota 3</label></td>
				<td><input type="txt" name="txtnum3"></td>
				<td><input type="submit" name="enviar"></td>
			</tr>
		</table>
	</form>

	<?php 
		$n1=$_POST['txtnum1'];
		$n2=$_POST['txtnum2'];
		$n3=$_POST['txtnum3'];

		$media=($n1+$n2+$n3)/3;

		if ($media<5){
			echo "Aluno Reprovado";
		}
		else if ($media>=5){
			echo "Aluno Aprovado";
		}
		else{
			echo "Digite As Três Notas";
		}
	 ?>

</body>
</html>
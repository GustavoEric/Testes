<!DOCTYPE html>
<html>
<head>
	<title>Atividade2</title>
	<meta charset="utf-8">
</head>
<body>
	<form action="Atividade2.php" method="POST">
		<label>Digite Nota 1</label>
		<input type="text" name="txtNota1">

		<br>

		<label>Digite Nota 2</label>
		<input type="text" name="txtNota2">

		<br>

		<label>Digite Nota 3</label>
		<input type="text" name="txtNota3">

		<input type="submit" name="btnEnviar" value="Enviar">

	</form>
	<?php
	$N1=$_POST['txtNota1'];
	$N2=$_POST['txtNota2'];
	$N3=$_POST['txtNota3'];
	$Media=($N1+$N2+$N3)/3;

	if ($Media<3){

		echo "Reprovado";
	}
	else if (($Media>=3)and($Media<5)){

		echo "Recuperação";
	}
	else{

		echo "Aprovado";
	}

	  ?>
</body>
</html>
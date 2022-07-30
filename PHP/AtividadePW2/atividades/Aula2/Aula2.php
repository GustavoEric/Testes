<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href="Style.css">
	<title>Aula 02 PHP</title>
	<meta charset="utf-8">
</head>
<body>
	<p class="p1">Exemplo IMC</p>
	<p>Aula 02</p>
	<a href="Atividade2.php">Media</a>
	<form action="Aula2.php" method="POST">

		<table border="1">
		
		<tr>
			<td><label>Peso</label></td>
			<td><input type="text" name="txtPeso"></td>
		</tr>

		<br>

		<tr>
			<td><label>Altura</label></td>
			<td><input type="text" name="txtAltura"></td>
		</table>
		</tr>
		<input type="submit" name="btnEnviar" value="Enviar">

	</form>
	<?php 
	
	$Peso=$_POST['txtPeso'];
	$Altura=$_POST['txtAltura'];

	$Imc=$Peso/($Altura*$Altura);

	echo "O IMC é $Imc <br>";

	if ($Imc<18.5){

		echo "Peso Baixo";
	}
	else if ($Imc<25){

		echo "Peso Normal";
	}
	else if ($Imc<30){

		echo "Sobrepeso";
	}
	else if ($Imc<35){

		echo "Obsidade Grau I";
	}
	else if ($Imc<40){

		echo "Obsidade Severa Grau II";
	}
	else{

		echo "Obsidade Grau III";
	}

 	?>
</body>
</html>
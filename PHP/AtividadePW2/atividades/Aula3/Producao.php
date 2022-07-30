<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Produção</title>
</head>
<body>
	<form action="Producao.php" method="POST">

		<table border="1">
		<tr>
		<td><label>Produção do Mês de Janeiro</label></td>
		<td><input type="text" name="txtMes1"></td>
		</tr>

		<tr>
		<td><label>Produção do Mês de Fevereiro</label></td>
		<td><input type="text" name="txtMes2"></td>
		</tr>

		<tr>
		<td><label>Produção do Mês de Março</label></td>
		<td><input type="text" name="txtMes3"></td>
		</tr>
		</table>
		<input type="submit" name="btnCalcular" value="Enviar">
	</form>

	<?php

		if(isset($_POST['btnCalcular'])){
		$mes1=$_POST['txtMes1'];
		$mes2=$_POST['txtMes2'];
		$mes3=$_POST['txtMes3'];

		$producao=($mes1+$mes2+$mes3)/3;

		echo "A Media de Produçãpo dos 3 Meses é: $producao <br>";
		}
		else{
			echo "Digite Algum Número";
		}

		if ($producao<100){
			echo "Situação Abaixo da Meta";
		}
		else if ($producao<150){
			echo "Dentro da Meta";
		}
		else{
			echo "Situação Acima da Meta";
		}

	  ?>
</body>
</html>
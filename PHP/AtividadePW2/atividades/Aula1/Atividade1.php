<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Primeiro Exemplo PHP</title>
</head>
<body>
	Exemplo em PHP<br>
	<form action="Atividade1.php" method="post">
		<label>Digite o Primeiro Numero</label>
		<input type="text" name="txtNum1"><br>
		<label>Digite o Segundo Numero</label>
		<input type="text" name="txtNum2"><br>
		<label>Digite o Terceiro Numero</label>
		<input type="text" name="txtNum3"><br>
		<input type="submit" name="btnEnviar" value="Enviar"> 
	</form>
		<?php 
			echo "<b>Hello World</b>";

			/*Atribuindo valor da txtNum1 e txtNum2 para $Num1 $Num2*/
			$Num1=$_POST['txtNum1'];
			$Num2=$_POST['txtNum2'];
			$Num3=$_POST['txtNum3'];

			/*Comaparação*/
			
				$Media=($Num1+$Num2+$Num3)/3;

				echo "<br>$Soma<br>";
				if ($Media>50){
					echo "Media Maior que 50 ";
				}
				else if ($Media==50){
					echo "Media Igual a 50";
				}
				else{
					echo "Media Menor que  50";
				}
		 ?>
</body>
</html>
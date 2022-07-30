<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Primeiro Exemplo PHP</title>
</head>
<body>
	Exemplo em PHP<br>
	<form action="Exemplo1.php" method="post">
		<label>Digite o Primeiro Numero</label>
		<input type="text" name="txtNum1"><br>
		<label>Digite o Segundo Numero</label>
		<input type="text" name="txtNum2"><br>
		<input type="submit" name="btnEnviar" value="Enviar"> 
	</form>
		<?php 
			echo "<b>Hello World</b>";

			/*Atribuindo valor da txtNum1 e txtNum2 para $Num1 $Num2*/
			$Num1=$_POST['txtNum1'];
			$Num2=$_POST['txtNum2'];

			/*Comaparação*/
			if ((empty($Num1)) || (empty($Num2))){
				echo"<br>

				Por Favor Digite os Numeros";
			}
			else{
				$Soma=$Num1+$Num2;

				echo "<br>$Soma<br>";
				if ($Soma>20){
					echo "Soma Maior que 20 ";
				}
				else if ($Soma==20){
					echo "Soma Igual a 20";
				}
				else{
					echo "Soma Menor ou igual a 20";
				}
			}
		 ?>
</body>
</html>
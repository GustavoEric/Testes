<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<form method="Post" action="tabuada.php">
		<label>Digite a Tabuada de 1 Até?</label>
		<input type="text" name="txttab">
		<label>Digite até que Número você quer Calcular</label>
		<input type="text" name="txtcalculo">
		<input type="submit" name="enviar">
	</form>
	<?php
		$n2=1;
		$n1=1;
		$tabuada =$_POST['txtcalculo'];
		$limite=$_POST['txttab'];
		echo "<table border=1><tr>";
		while (($n2<=$tabuada)&&($n1<=$limite)) {
				$resultado=$n2*$n1;
				
				echo "<td>$n1 X $n2 = $resultado</td>";
				$n1+=1;
				if($n1==$limite+1){
					echo "</tr>";
					$n2+=1;
					$n1=1;
				}
			}
		echo "</table>";
		
	  ?>
</body>
</html>
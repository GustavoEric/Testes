<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<?php 
		$i=1;
		$acum=0;
		echo"Laco de Repetição - While<br>";
		while ($i<=10) {
			echo"$i<br>";
			$acum+=$i;
			$i++;
		}
		echo"Somatória: $acum<br>";
		echo "Laco de repeticao For";
		for ($i=1; $i<=50; $i++) { 
			echo"$i<br>";
			$acum+=$i;
		}
		$res =$acum/50;
		echo"Media: $res<br>";

		$i=1;
		$cont=0;
		echo "Laco de repeticao Do While";
		do{
			echo"$i<br>";
			if($i>=18){
				$cont++;
			}
			$acum+=$i;
			$i++;

		}while($i<=20);
		$res=$acum/20;
		echo"Media: $res<br>";
		echo"Somatória: $acum<br>";
	 ?>
</body>
</html>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<?php

	$n1=array();

          		$n1[0] = 15;
          		$n1[1] = 25;
          		$n1[2] = 45;
          		$n1[3] = 10;
          		$n1[4] = 9;
          		$n1[5] = 10;
          		$n1[6] = 400;
          		$n1[7] = 300;
          		$n1[8] = 6;
          		$n1[9] = 12;
          		$n1[10] = 15;
          		$n1[11] = 25;
          		$n1[12] = 45;
          		$n1[13] = 10;
          		$n1[14] = 9; 

          		
          		$soma=0;
          		$media=0;

          		for ($i=0; $i<=14; $i++)
          		{
          			$soma+=$n1[$i];

          			echo "A numero da posição $i do vetor é: ".$n1[$i]."<br>";
          		}
          		$media=$soma/15;
          		echo "<br>Soma: $soma<br>";
          		echo"Media: $media";
          	
	 ?>

</body>
</html>
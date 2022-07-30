<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<?php

	$cidade=array();

          		$cidade[0] = "Caieiras";
          		$cidade[1] = "Franco da Rocha";
          		$cidade[2] = "Franco da Rocha";
          		$cidade[3] = "Francisco Morato";
          		$cidade[4] = "Jundiai"; 

          		$c=0;
          		strtolower($cidade[1]);

          		for ($i=0; $i<=4; $i++)
          		{
          			echo "A Cidade da posição $i do vetor é: ".$cidade[$i]."<br>";

          			if($cidade[$i]=="Franco da Rocha")
          			{
          				$c++;
          			}
          		}
          		echo "<br> Franco da Rocha Aparece ".$c." Vezes";
          	
	 ?>

</body>
</html>
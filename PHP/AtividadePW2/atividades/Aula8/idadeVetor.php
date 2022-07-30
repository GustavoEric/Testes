<html>
        <head>
            <meta charset="utf-8">
            <title>Idade</title>
        </head>
          <body>
            
          	<?php

          		$idade=array();

          		$idade[0] = 10;
          		$idade[1] = 18;
          		$idade[2] = 20;
          		$idade[3] = 30;
          		$idade[4] = 17;
          		$idade[5] = 23;
          		$idade[6] = 90;
          		$idade[7] = 75;
          		$idade[8] = 13;
          		$idade[9] = 05;


          		$c=0;

          		for ($i=0; $i<=9; $i++)
          		{
          			echo "O valor da posição $i do vetor é: ".$idade[$i]."<br>";

          			if($idade[$i]>=18)
          			{
          				$c++;
          			}
          		}
          		echo "<br> Tem mais que 18 anos: ".$c." pessoas";
          	?>

           </body>
          </html>
            	
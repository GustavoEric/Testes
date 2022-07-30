<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Exemplo laço While</title>
</head>
<body>
	<?php 

		$cont=0;
		$seconds=1;

		while ($cont<=10) {
			sleep($seconds);
			echo "$cont<br>";
			$cont+=1;
		}

	 ?>
</body>
</html>
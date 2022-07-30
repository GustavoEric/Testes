<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>

<body>
	<form method="POST" action="copa.php">
	<input type="submit" name="envia">
	<select name="Copa">
	<?php
		$copa=1930;
		while ($copa<=2022) {
			if (($copa!=1942)&&($copa!=1946)){
			echo "<option value=".$copa.">".$copa."</option>";
			}
			$copa+=4;
		}

	  ?>
	  </select>
</form>
	<?php
		$Copa=$_POST['Copa'];
		switch ($Copa){
		 	case '1930':
		 		echo "Sede: Uruguai<br>";
		 		echo "Campeão: Uruguai";
		 		break;

		 	case '1934':
		 		echo "Sede: Itália<br>";
		 		echo "Campeão: Itália";
		 		break;

		 	case '1938':
		 		echo "Sede: França<br>";
		 		echo "Campeão: Itália";
		 		break;

		 	case '1950':
		 		echo "<font color=green>Sede: Brasil<br></font>";
		 		echo "Campeão: Itália";
		 		break;

		 	case '1954':
		 		echo "Sede: Suiça<br>";
		 		echo "Campeão: Alemanha Ocidental";
		 		break;

		 	case '1958':
		 		echo "Sede: Suécia<br>";
		 		echo "<font color=green>Campeão: Brasil</font>";
		 		break;

		 	case '1962':
		 		echo "Sede: Chile<br>";
		 		echo "<font color=green>Campeão: Brasil</font>";
		 		break;

		 	case '1966':
		 		echo "Sede: Inglaterra<br>";
		 		echo "Campeão: Inglaterra";
		 		break;
		 	
		 	case '1970':
		 		echo "Sede: México<br>";
		 		echo "<font color=green>Campeão: Brasil</font>";
		 		break;

		 	case '1974':
		 		echo "Sede: Alemanha Ocidental<br>";
		 		echo "Campeão: Alemanha Ocidental";
		 		break;

		 	case '1978':
		 		echo "Sede: Argentina<br>";
		 		echo "Campeão: Argentina";
		 		break;

		 	case '1982':
		 		echo "Sede: Espanha<br>";
		 		echo "Campeão: Itália";
		 		break;

		 	case '1986':
		 		echo "Sede: México<br>";
		 		echo "Campeão: Argentina";
		 		break;

		 	case '1990':
		 		echo "Sede: Itália<br>";
		 		echo "Campeão: Alemanha Ocidental";
		 		break;

		 	case '1994':
		 		echo "Sede: Estados Unidos<br>";
		 		echo "<font color=green>Campeão: Brasil</font>";
		 		break;

		 	case '1998':
		 		echo "Sede: França<br>";
		 		echo "Campeão: França";
		 		break;

		 	case '2002':
		 		echo "Sede: Coreia do Sul<br>";
		 		echo "<font color=green>Campeão: Brasil</font>";
		 		break;

		 	case '2006':
		 		echo "Sede: Alemanha<br>";
		 		echo "Campeão: Itália";
		 		break;

		 	case '2010':
		 		echo "Sede: África do Sul<br>";
		 		echo "Campeão: Espanha";
		 		break;

		 	case '2014':
		 		echo "<font color=green>Sede: Brasil</font>";
		 		echo "Campeão: Alemanha<br>";
		 		
		 		break;

		 	case '2018':
		 		echo "Sede: Rússia<br>";
		 		echo "Campeão: França";
		 		break;

		 	case '2022':
		 		echo "Sede: Catar<br>";
		 		break;


		 	default:

		 		break;
		 }
	?>
</body>
</html>
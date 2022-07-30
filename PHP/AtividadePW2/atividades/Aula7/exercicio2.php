
<!DOCTYPE html>
<html lang="pt-br">
<head>
<meta charset="UTF-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>While</title>
</head>
<body>
<form method="post">
<select name="exemplo">
<?php
for ($i = 1896; $i <= 2032; $i+=4){
if(($i != 1916) && ($i != 1940) && ($i != 1944)){
echo"<option value=".$i.">"."ano " .$i."</option>";
}
}
?>
</select>
<br>
<br>
<input type="submit" value="Enviar">
<br>
<br>
<?php
$ano = $_POST['exemplo'];
switch ($ano) {
case 1896:
echo"Sede: GRE<br>";
echo"Maior número de medalhas: USA";
break;
case 1900:
echo"Sede: FRA<br>";
echo"Maior número de medalhas: FRA";
break;
case 1904:
echo"Sede: USA<br>";
echo"Maior número de medalhas: USA";
break;
case 1908:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: GBR";
break;
case 1912:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: GBR";
break;
case 1916:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: GBR";
break;
case 1920:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: GBR";
break;
case 1924:
echo"Sede: SWE<br>";
echo"Maior número de medalhas: USA";
break;
case 1928:
echo"Sede: NED (Países Baixos)<br>";
echo"Maior número de medalhas: USA";
break;
case 1932:
echo"Sede: USA<br>";
echo"Maior número de medalhas: USA";
break;
case 1936:
echo"Sede: GER<br>";
echo"Maior número de medalhas: GER";
break;
case 1948:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: USA";
break;
case 1952:
echo"Sede: AUS<br>";
echo"Maior número de medalhas: USA";
break;
case 1956:
echo"Sede: AUS<br>";
echo"Maior número de medalhas: URS";
break;
case 1960:
echo"Sede: ITA<br>";
echo"Maior número de medalhas: URS";
break;
case 1964:
echo"Sede: JPN<br>";
echo"Maior número de medalhas: USA";
break;
case 1968:
echo"Sede: MEX<br>";
echo"Maior número de medalhas: USA";
break;
case 1972:
echo"Sede: FRG (Alemanha Ocidental)<br>";
echo"Maior número de medalhas: URS";
break;
case 1976:
echo"Sede: CAN<br>";
echo"Maior número de medalhas: URS";
break;
case 1980:
echo"Sede: URS<br>";
echo"Maior número de medalhas: URS";
break;
case 1984:
echo"Sede: USA<br>";
echo"Maior número de medalhas: USA";
break;
case 1988:
echo"Sede: KOR<br>";
echo"Maior número de medalhas: URS";
break;
case 1992:
echo"Sede: ESP<br>";
echo"Maior número de medalhas: EUN (Equipe Unificada)";
break;
case 1996:
echo"Sede: USA<br>";
echo"Maior número de medalhas: USA";
break;
case 2000:
echo"Sede: AUS<br>";
echo"Maior número de medalhas: USA";
break;
case 2004:
echo"Sede: GRE<br>";
echo"Maior número de medalhas: USA";
break;
case 2008:
echo"Sede: CHN<br>";
echo"Maior número de medalhas: CHN";
break;
case 2012:
echo"Sede: GBR<br>";
echo"Maior número de medalhas: USA";
break;
case 2016:
echo"Sede: BRA<br>";
echo"Maior número de medalhas: USA";
break;
case 2020:
echo"Sede: JPN<br>";
echo"Maior número de medalhas: USA";
break;
case 2024:
echo"Sede: FRA<br>";
echo"Jogos ainda não iniciados";
break;
case 2028:
echo"Sede: USA<br>";
echo"Jogos ainda não iniciados";
break;
case 2032:
echo"Sede: AUS<br>";
echo"Jogos ainda não iniciados";
break;

default:
echo"Escolha um ano na lista.";
break;
}
?>
</form>
</body>
</html>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Consulta do Aluno</title>
</head>
<body>
	<?php
	require_once('conn.php');
	$sql=mysqli_query($conn,"SELECT * FROM tbaluno");

	while ($linha=mysqli_fetch_array($sql)){
		$cod=$linha['CodAluno'];
		$nome=$linha['NomeAluno'];
		echo "<br><table><tr>Código do Professor: $cod</td></tr>";
		echo "<tr><td>Nome do Aluno: </td><td>$nome</td></tr></table>";
	}

	 ?>
</body>
</html>
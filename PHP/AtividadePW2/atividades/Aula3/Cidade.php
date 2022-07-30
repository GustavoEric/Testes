<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Cidade</title>
</head>
<body>

	<form action="Cidade.php" method="POST">
		
		<select name="slCidade">
			
			<option>Cidade de Origem</option>
			<option value="FR">Franco da Rocha</option>
			<option value="FM">Francisco Morato</option>
			<option value="CA">Caieiras</option>
			<option value="SP">São Paulo</option>

		</select>

			<br>

			<input type="radio" name="rdCidade">Franco da Rocha<br>
			<input type="radio" name="rdCidade">Francisco Morato<br>

			<input type="radio" name="rdEstadoCivil"> Solteiro<br>
			<input type="radio" name="rdEstadoCivil"> Casado<br>

			<input type="submit" name="btnEnviar" value="resultado">
	</form>

		<?php 
			$cidade=$_POST['slCidade'];

			if($cidade=="FR"){
				echo "Você escolheu Franco da Rocha";
			}
			else if($cidade=="FM"){
				echo "Você escolheu Francisco MOrato";
			}
			else if($cidade=="CA"){
				echo "Você escolheu Caieiras";
			}
			else if($cidade=="SP"){
				echo "Você escolheu São Paulo";
			}
	 	?>
</body>
</html>
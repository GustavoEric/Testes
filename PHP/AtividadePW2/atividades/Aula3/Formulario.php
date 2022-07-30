<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Meu Primeiro Formulario</title>
</head>
<body>
	<fieldset>
		<legend>Formulário 2 2022</legend>
		<form method="POST" action="">
			
			<table>
				<tr>
					<td>
						Nome:
					</td>
					<td>
						<input type="text" name="txt_nome" id="txt_nome" size="30" placeholder="Digite Seu Nome">
					</td>
				</tr>
				<tr>
					<td>
						Sexo:
					</td>
					<td>
						<input type="radio" name="rdb_sexo" value="masculino">Masculino
						<input type="radio" name="rdb_sexo" value="faminino">Feminino

					</td>
				</tr>
				<tr>
					<td>
						Nacionalidade (Brasileiro):
					</td>
					<td>
						<input type="radio" name="rbd_N" value="sim">
						Sim
						<input type="radio" name="rdb_N" value="nao">
						Não

					</td>
				</tr>
				<tr>
					<td>
						Data de Nascimento
					</td>
					<td>
						<input type="date" name="data">
					</td>
				</tr>
				<tr>
					<td>
						Documentos:
					</td>
					<td>
						<input type="file" name="doc">
					</td>
				</tr>
				<tr>
					<td>
						Estado Civil:
					</td>
					<td>
						<select name="estado">
							<option value="">&nbsp;</option>
							<option value="sol">Solteiro</option>
							<option value="cas">Casado</option>
							<option value="sep">Separado</option>
						</select>
					</td>
				</tr>
				<tr>
					<td>
						Email:
					</td>
					<td>
						<input type="email" name="email">
					</td>
				</tr>
				<tr>
					<td>
						Senha:
					</td>
					<td>
						<input type="password" name="senha">
					</td>
				</tr>
				<tr>
					<td>
						Mensagem:
					</td>
					<td>
						<textarea name="Mensagem" rows="5" cols="25"></textarea>
					</td>
				</tr>
				<tr>
					<td>
						Área de Preferência:
					</td>
					<td>
						<input type="checkbox" name="humanas" value="humanas">Humanas
						<input type="checkbox" name="exatas" value="exatas">Exatas
						<input type="checkbox" name="saude" value="saude">Saude
					</td>
				</tr>
				<tr>
					<td>
						<center colspan="2">
							<input type="reset" name="Limpar">
							<input type="submit" name="Cadastro">
						</center>
					</td>
				</tr>
			</table>
		</form>
	</fieldset>
	<?php error_reporting(0);

	$nome = $_POST['txt_nome'];
	$sexo = $_POST['rdb_sexo'];
	$nacionalidade = $_POST['rdb_N'];
	$data = $_POST['data'];
	$file = $_POST['doc'];
	$estado = $_POST['estado'];
	$email = $_POST['email'];
	$senha = $_POST['senha'];
	$mensagem = $_POST['Mensagem'];
	$exatas = $_POST['exatas'];
	$humanas = $_POST['humanas'];
	$saude = $_POST['saude'];
	//verificar
	if ($estado == 'sol'){
		$valor ='Solteiro';
	}
	else if ($estado == 'cas'){
		$valor ='Casado';
	}
	else if ($estado == 'sep'){
		$valor ='Separado';
	}
	else{
		echo "<script>alert('Escolha um Estado!);</script>";
	}
	//Mostrar valores 
	echo 'Nome:&nbsp;'.$nome;
	echo '<br>Sexo:&nbsp'.$sexo;
	echo '<br>Data de Nascimento:&nbsp'.$data;
	echo '<br>Documento:&nbsp'.$file;
	echo '<br>Estado Civil:&nbsp'.$valor;
	echo '<br>Email:&nbsp'.$email;
	echo '<br>Senha:&nbsp'.$senha;
	echo '<br>Mensagem:&nbsp'.$mensagem;
	echo '<br>Área de Transferência:&nbsp'.$exatas;
	echo '<br>Área de Transferência:&nbsp'.$humanas;
	echo '<br>Área de Transferência:&nbsp'.$saude;
	  ?>

</body>
</html>
<?php

require_once('conn.php');
		$nomeCliente=$_POST['txtNome'];
		$Ende = $_POST['txtEnde'];
		$Cep = $_POST['txtCEP'];
		$Tel = $_POST['txtTEL'];
		$Cel = $_POST['txtCEL'];
		$Email = $_POST['txtEmail'];
		$insere= mysqli_query($conn, "INSERT INTO tbcliente(NomeCliente,EnderecoCliente,CepCliente,TelCliente,CelCliente,EmailCliente) values('$nomeCliente','$Ende','$Cep','$Tel','$Cel','$Email')") or 
		die (mysqli_error($conn));

		if(mysqli_affected_rows($conn)!=0){
		echo "
			<META HTT`-EQUIV=REFRESH CONTENT =
				'0;URL=CadCliente.php'>
			<script type=\"text/javascript\">
				alert(\"Cliente cadastrado com sucesso.\");
			</script>";
		}
		else
		{
		echo "
			<META HTTP-EQUIV=REFRESH CONTENT = 
				'0;URL=CadCliente.php'>
			<script type=\"text/javascript\">
				alert(\"Erro ao cadastrar\");
			</script>
			";
	}

  ?>
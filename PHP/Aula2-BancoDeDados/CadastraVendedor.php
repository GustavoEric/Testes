<?php

require_once('conn.php');
		$nomeVendedor=$_POST['txtNomeV'];
		$Tel = $_POST['txtTELV'];
		$Cel = $_POST['txtCELV'];
		$Email = $_POST['txtEmailV'];
		$insere= mysqli_query($conn, "INSERT INTO tbvendedor(NomeVendedor,TelVendedor,CelVendedor,EmailVendedor) values('$nomeVendedor','$Tel','$Cel','$Email')") or 
		die (mysqli_error($conn));

		if(mysqli_affected_rows($conn)!=0){
		echo "
			<META HTT`-EQUIV=REFRESH CONTENT =
				'0;URL=CadCliente.php'>
			<script type=\"text/javascript\">
				alert(\"Vendedor cadastrado com sucesso.\");
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
<?php

require_once('conn.php');
		$Produto=$_POST['txtNProduto'];
		$QTD = $_POST['txtQTD'];
		$Preco = $_POST['txtPreco'];
		$insere= mysqli_query($conn, "INSERT INTO tbproduto(NomeProduto,QtdeEstoque,PrecoProduto) values('$Produto','$QTD','$Preco')") or 
		die (mysqli_error($conn));

		if(mysqli_affected_rows($conn)!=0){
		echo "
			<META HTT`-EQUIV=REFRESH CONTENT =
				'0;URL=CadCliente.php'>
			<script type=\"text/javascript\">
				alert(\"Produto cadastrado com sucesso.\");
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
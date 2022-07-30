<?php

require_once('conn.php');
		$nomeAL=$_POST['txtNome'];
		$insere= mysqli_query($conn, "INSERT INTO tbaluno(NomeAluno) 
		values('$nomeAL')") or die (mysqli_error());

	if(mysqli_affected_rows($conn)!=0){
		echo "
			<META HTT`-EQUIV=REFRESH CONTENT =
				'0;URL=CadAluno.php'>
			<script type=\"text/javascript\">
				alert(\"Aluno cadastrado com sucesso.\");
			</script>";
	}
	else
	{
	echo "
			<META HTTP-EQUIV=REFRESH CONTENT = 
				'0;URL=cadAluno.php'>
			<script type=\"text/javascript\">
				alert(\"Erro ao cadastrar\");
			</script>
			";
	}



  ?>
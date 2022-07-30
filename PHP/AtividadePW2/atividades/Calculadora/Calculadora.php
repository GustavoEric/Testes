<!DOCTYPE html>
<html>
<head>
	<title></title>
</head>
<body>
	<form action="Calculadora.php" method="POST">
		<center>
			<table border="1">
				<tr>
					<td colspan="4"><label>Calculadora</label></td>
				</tr>
				<tr>
					<td colspan="4"><label>Digite Um Numero</label></td>
				</tr>
				<tr>
					<td colspan="4"><input type="text" name="txtNum"></td>
				</tr>
				<tr>
					<td><input type="submit" name="btnAdicao" value="+"></td>
					<td><input type="submit" name="btnSub" value="-"></td>
					<td><input type="submit" name="btnMul" value="x"></td>
					<td><input type="submit" name="btnDiv" value="/"></td>
				</tr>
			</table>
		</center>
	</form>

	<?php 
		$n1=$_POST['txtNum'];
		$numero=1;

		if (isset($_POST['btnAdicao'])&&($numero==1)){
			numero+1;
			$Adi=$Adi+$n1;
			$n1=0;
		}
		if (isset($_POST['btnAdicao'])&&($numero>2)){
			$Adi=$Adi+$n1;
		}
	?>
</body>
</html>
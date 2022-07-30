<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<form action="exercicio4.php" method="post">

    <label>
    	Digite Numero1
    </label>
    <input type="txt" name="n1">

     <label>
    	Digite Numero2
    </label>
    <input type="txt" name="n2">

        <input type="submit" name="Enviar">

   	
   </form>

   <?php
    $n1 = $_POST['n1'];
    $n2 = $_POST['n2'];

   for ($i=$n1+1; $i<$n2 ; $i++) { 
                

                if ($i %2 == 0) {

                   echo "$i<br>"; 
                    
                }
                
            }
    ?>
    
</body>
</html>

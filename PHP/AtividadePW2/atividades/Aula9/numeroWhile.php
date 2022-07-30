<!DOCTYPE html>
<html>
<head>
   <title>Números Menores</title>
   <meta charset="utf-8">
</head>
<body>
   <form action="" method="post">
    <table>
      <tr>
        <td><input type="number" id="num" name="num"></td>
        <td><input type="submit" value="Calcular" name="btncale"></td>
      </tr>
   </table>
   </form>
   <?php
      $num=$_POST['num'];
      $c=1;
     while($c<$num) {
        echo $c."<br>";
        $c+=1;
      }
   ?>
   <br/>
   <br/>
      <a href="index.php"><button>Voltar</button></a>
   <br/>
</body>
</html>
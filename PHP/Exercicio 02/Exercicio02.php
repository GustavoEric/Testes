<html>
    <head>
    <meta charset="utf-8">
        <title> Abadás </title>
    </head>
    <body>
        <form action="" method="post">
            <table border=0>
                <tr>
                     <td> Quantidade de Abadas P </td>
                     <td> <input type="text" id="textn1" name="txtnp"> </td>
                </tr>
                <tr>
                     <td> Quantidade de Abadas M </td>
                     <td> <input type="text" id="textn2" name="txtnm"> </td>
                </tr>
                <tr>
                     <td> Quantidade de Abadas G </td>
                     <td> <input type="text" id="textn3" name="txtng"> </td>
                </tr>
            </table>
            <input type="submit" value="Calcular" id="btnCalc" name="btnCalc">
       </form>

    
    <?php
    error_reporting(0);
    $camisa=array();
    $camisa[0] = 85;
    $camisa[1] = 95;
    $camisa[2] = 105;
                
    $numP=$_POST['txtnp'];
    $numM=$_POST['txtnm'];
    $numG=$_POST[ 'txtng'];
    $total = $numP+$numM+$numG;
    $valor=$total * 100;
    if($total>=20)
    {
        $va=$valor*0.75;
    }
    elseif($total>=10)
    {
        $va=$valor*0.85;
    }
    elseif($total>=5)
    {
        $va=$valor*0.90;
    }
    else
    {
        $va=$valor;
    }

    $vb=($numP* $camisa[0]+$numM* $camisa[1]+$numG* $camisa[2]);
    echo "Valor total dos Abadas na empresa A é $va. O valor total das Abadas na empresa B é $vb<br>";

    if($va<$vb){
        echo"<br> Compre na empresa A<br>";
    }
    elseif ($vb<$va){
        echo"<br> Compre na empresa B<br>";
    }
    else{
       echo" <br> Compre em qualquer uma das empresas<br>";
    }
    ?>
</body>
</html>
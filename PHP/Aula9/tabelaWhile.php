<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Tabela</title>
</head>
<body>
<body>
<table border="1">
    <?php
        $c=1;
            while ($c<= 10) {
                 echo "<tr><td>".$c."</td></tr>";
                 $c+=1;
             }
    ?>
</table>
<a href="index.php"><button>Voltar</button></a>
<br/>
</body>
</html>
<!DOCTYPE html>
<html>
<head>
    <title>Tabela</title>
</head>
<body>
<body>
        <table border="1">
            <?php
                for($i=1;$i<=10; $i+=1){
                    echo "<tr><td>".$i."</td></tr>";
                }
            ?>
        </table>
    <br/>
    <br/>
       <a href="index.php"><button>Voltar</button></a>
    <br/>
</body>
</html>
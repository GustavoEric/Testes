package etec.com.br.Gustavo.appedittext;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    //Objetos Java para Conectar aos Objetos XML
    Button btCad;
    EditText edNome;
    EditText edSob;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Conectando os Objetos Java aos Objetos XML
        btCad = findViewById(R.id.btnCadastra);
        edNome = findViewById(R.id.edtNome);
        edSob = findViewById(R.id.edtSobrenome);

        //Preparar o Botão Para o Clique

        btCad.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                //Criar uma variavel Auxiliar Para Guardar o nome digitado

                String nomeDigitado,Sobrenome;

                //Recuperar o Nome que foi digitado

                nomeDigitado = edNome.getText().toString();
                Sobrenome = edSob.getText().toString();
                edNome.setText("");
                edSob.setText("");
                edNome.requestFocus();

                //Exibir Nome em um Toast
                Toast.makeText(MainActivity.this, "Nome: "+nomeDigitado+" "+Sobrenome, Toast.LENGTH_LONG).show();
            }
        });
    }
}

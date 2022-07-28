package etec.com.br.gustavo.quiz_gustavo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    EditText edNome;
    Button btOK;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        edNome = findViewById(R.id.edtNome);
    }
    public void butaoOK (View v){
        if(edNome.getText().toString().isEmpty()){
            edNome.setError("Informe o Nome");
        }
        else{
            Intent tela2 = new Intent(MainActivity.this,TelaPergunta1.class);
            //Intent P2 = new Intent(MainActivity.this,TelaPergunta2.class);
            String nome= edNome.getText().toString();
            //P2.putExtra("NomeJogadorP2",nome);
            tela2.putExtra("NomeJogador",nome);

            startActivity(tela2);
        }

    }
}
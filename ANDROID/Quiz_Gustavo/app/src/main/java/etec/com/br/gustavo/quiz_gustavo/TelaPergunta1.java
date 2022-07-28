package etec.com.br.gustavo.quiz_gustavo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class TelaPergunta1 extends AppCompatActivity {

    TextView tVNome;
    RadioGroup rdgP1;
    Button btOK;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_pergunta1);

        tVNome=findViewById(R.id.txtVNomeP1);

        Intent telaAtual = getIntent();

        Bundle valoresRecebidos = telaAtual.getExtras();

        tVNome.setText(valoresRecebidos.getString("NomeJogador"));

        rdgP1 = findViewById(R.id.rdgPergunta1);

    }

    public void butaoOKP1 (View v){
      int op = rdgP1.getCheckedRadioButtonId();
      int pontosP1=0;

        if (op==R.id.rdbA){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
            pontosP1 +=1;

        }
        else if (op==R.id.rdbB){
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        else if (op==R.id.rdbC){
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        else if (op==R.id.rdbD){
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }

        Intent TP2 = new Intent(TelaPergunta1.this,TelaPergunta2.class);
        TP2.putExtra("PontosJogadorP1",pontosP1);

        startActivity(TP2);

    }
}
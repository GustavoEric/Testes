package etec.com.br.gustavo.quizzzgustavo;

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

    }

    public void butaoOKP1 (View v){
        int op = rdgP1.getCheckedRadioButtonId();

        if (op==R.id.rdbA){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
        }

    }

}
package etec.com.br.gustavo.quiz_gustavo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class TelaPergunta2 extends AppCompatActivity {

    TextView tVNomeP2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_pergunta2);
/*
        tVNomeP2 = findViewById(R.id.txtVNomeP2);

        Intent telaAtual2 = getIntent();

        Bundle valoresRecebidos2 = telaAtual2.getExtras();

        tVNomeP2.setText(valoresRecebidos2.getString("NomeJogadorP2"));*/
    }

}
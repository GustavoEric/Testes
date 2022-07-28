package com.example.quiz_gustavoeric;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class TelaPergunta1 extends AppCompatActivity {

    TextView tVNome;
    RadioGroup rdgP1;
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

        if (op==R.id.rdbAP1){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
            pontosP1 +=1;

        }
        else{
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        String pontoStr;
        pontoStr = String.valueOf(pontosP1);
        Intent TP2 = new Intent(TelaPergunta1.this,TelaPergunta2.class);
        TP2.putExtra("PontosJogadorP1",pontoStr);

        String nome2= tVNome.getText().toString();
        TP2.putExtra("NomeJogador2",nome2);

        startActivity(TP2);

    }
}
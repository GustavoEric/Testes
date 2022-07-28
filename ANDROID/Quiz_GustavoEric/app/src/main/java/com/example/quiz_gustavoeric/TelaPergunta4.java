package com.example.quiz_gustavoeric;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class TelaPergunta4 extends AppCompatActivity {

    TextView tVNomeP4,tVPontosP4;
    RadioGroup rdgP4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_pergunta4);

        tVNomeP4 = findViewById(R.id.txtVNomeP4);
        tVPontosP4 = findViewById(R.id.txtVPontosP4);

        Intent telaAtual4 = getIntent();

        Bundle valoresRecebidos4 = telaAtual4.getExtras();

        tVPontosP4.setText(valoresRecebidos4.getString("PontosJogadorP3"));
        tVNomeP4.setText(valoresRecebidos4.getString("NomeJogador4"));
        rdgP4 = findViewById(R.id.rdgPergunta4);

    }
    public void butaoOKP4 (View v){
        Intent telaAtual4 = getIntent();

        Bundle valoresRecebidos4 = telaAtual4.getExtras();

        tVPontosP4.setText(valoresRecebidos4.getString("PontosJogadorP3"));
        String ponto = valoresRecebidos4.getString("PontosJogadorP3");

        int op = rdgP4.getCheckedRadioButtonId();
        int pontosP4 = Integer.parseInt(ponto);
        String somaStr= String.valueOf(pontosP4);
        Log.e("Pontos:",somaStr);

        if (op==R.id.rdbBP4){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
            pontosP4 +=1;

        }
        else{
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        String pontoStr;
        pontoStr = String.valueOf(pontosP4);
        Log.e("Pontos Somados:",pontoStr);
        Intent TP5 = new Intent(TelaPergunta4.this,TelaPergunta5.class);
        TP5.putExtra("PontosJogadorP4",pontoStr);

        String nome5= tVNomeP4.getText().toString();
        TP5.putExtra("NomeJogador5",nome5);

        startActivity(TP5);

    }
}
package com.example.quiz_gustavoeric;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class TelaPergunta2 extends AppCompatActivity {

    TextView tVNomeP2,tVPontosP2;
    RadioGroup rdgP2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_pergunta2);
        tVNomeP2 = findViewById(R.id.txtVNomeP2);
        tVPontosP2 = findViewById(R.id.txtVPontosP2);

        Intent telaAtual2 = getIntent();

        Bundle valoresRecebidos2 = telaAtual2.getExtras();

        tVPontosP2.setText(valoresRecebidos2.getString("PontosJogadorP1"));
        tVNomeP2.setText(valoresRecebidos2.getString("NomeJogador2"));
        rdgP2 = findViewById(R.id.rdgPergunta2);
    }


    public void butaoOKP2 (View v){
        Intent telaAtual2 = getIntent();

        Bundle valoresRecebidos2 = telaAtual2.getExtras();

        tVPontosP2.setText(valoresRecebidos2.getString("PontosJogadorP1"));
        String ponto = valoresRecebidos2.getString("PontosJogadorP1");

        int op = rdgP2.getCheckedRadioButtonId();
        int pontosP2 = Integer.parseInt(ponto);
        String somaStr= String.valueOf(pontosP2);
        Log.e("Pontos:",somaStr);

        if (op==R.id.rdbCP2){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
            pontosP2 +=1;

        }
        else{
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        String pontoStr;
        pontoStr = String.valueOf(pontosP2);
        Log.e("Pontos Somados:",pontoStr);
        Intent TP3 = new Intent(TelaPergunta2.this,TelaPergunta3.class);
        TP3.putExtra("PontosJogadorP2",pontoStr);

        String nome3= tVNomeP2.getText().toString();
        TP3.putExtra("NomeJogador3",nome3);

        startActivity(TP3);

    }

}
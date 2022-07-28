package com.example.quiz_gustavoeric;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class TelaPergunta3 extends AppCompatActivity {


    TextView tVNomeP3,tVPontosP3;
    RadioGroup rdgP3;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_pergunta3);

        tVNomeP3 = findViewById(R.id.txtVNomeP3);
        tVPontosP3 = findViewById(R.id.txtVPontosP3);

        Intent telaAtual3 = getIntent();

        Bundle valoresRecebidos3 = telaAtual3.getExtras();

        tVPontosP3.setText(valoresRecebidos3.getString("PontosJogadorP2"));
        tVNomeP3.setText(valoresRecebidos3.getString("NomeJogador3"));
        rdgP3 = findViewById(R.id.rdgPergunta3);

    }
    public void butaoOKP3 (View v){
        Intent telaAtual3 = getIntent();

        Bundle valoresRecebidos3 = telaAtual3.getExtras();

        tVPontosP3.setText(valoresRecebidos3.getString("PontosJogadorP2"));
        String ponto = valoresRecebidos3.getString("PontosJogadorP2");

        int op = rdgP3.getCheckedRadioButtonId();
        int pontosP3 = Integer.parseInt(ponto);
        String somaStr= String.valueOf(pontosP3);
        Log.e("Pontos:",somaStr);

        if (op==R.id.rdbAP3){
            Toast.makeText(this, "Resposta Correta", Toast.LENGTH_SHORT).show();
            pontosP3 +=1;

        }
        else{
            Toast.makeText(this, "Resposta Errada", Toast.LENGTH_SHORT).show();
        }
        String pontoStr;
        pontoStr = String.valueOf(pontosP3);
        Log.e("Pontos Somados:",pontoStr);
        Intent TP4 = new Intent(TelaPergunta3.this,TelaPergunta4.class);
        TP4.putExtra("PontosJogadorP3",pontoStr);

        String nome4= tVNomeP3.getText().toString();
        TP4.putExtra("NomeJogador4",nome4);

        startActivity(TP4);

    }
}

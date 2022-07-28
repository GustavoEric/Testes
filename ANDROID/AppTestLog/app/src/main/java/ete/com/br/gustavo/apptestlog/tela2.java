package ete.com.br.gustavo.apptestlog;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class tela2 extends AppCompatActivity implements View.OnClickListener {

    Button btUm,btDois,btVoltar;
    String botaoClicado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela2);
        btUm = findViewById(R.id.btnUmT2);
        btDois = findViewById(R.id.btnDoisT2);
        btVoltar = findViewById(R.id.btnVoltar);

        btUm.setOnClickListener(this);
        btDois.setOnClickListener(this);
        btVoltar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()){
            case R.id.btnUmT2:
                botaoClicado = "Botão 1 da Tela 2";
                Log.i("BOTÃO CLICADO:",botaoClicado);
                break;
            case  R.id.btnDoisT2:
                botaoClicado = "Botão 2 da Tela 2";
                Log.i("BOTÃO CLICADO:",botaoClicado);
                break;
            case R.id.btnVoltar:
                botaoClicado ="Voltar da Tela 2";
                Log.i("BOTÃO CLICADO:",botaoClicado);
                finish();

        }

    }

}
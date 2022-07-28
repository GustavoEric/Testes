package ete.com.br.gustavo.apptestlog;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button botao1;
    String botaoClicado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        botao1=findViewById(R.id.btnUm);

        botao1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                botaoClicado = "Botão 1";
                int v1,v2,soma;
                v1=10;
                v2=7;
                soma=v1+v2;
                Log.i("BOTÃO CLICADO",botaoClicado);
                Log.w("VARIAVEL V1",String.valueOf(v1));
                Log.w("VARIAVEL V2",String.valueOf(v2));
                Log.e("VARIAVEL SOMA",String.valueOf(soma));
            }
        });
    }

    //Método para o botão 2
    public void  botao2(View v){
        botaoClicado = "Botão 2";
        int v1,v2,soma;
        v1=5;
        v2=5;
        soma=v1+v2;
        Log.i("BOTÃO CLICADO",botaoClicado);
        Log.w("VARIAVEL V1",String.valueOf(v1));
        Log.w("VARIAVEL V2",String.valueOf(v2));
        Log.e("VARIAVEL SOMA",String.valueOf(soma));

    }

    //Método para o Botão tela2
    public void tela2(View v){
        Intent t2 = new Intent(MainActivity.this,tela2.class);
        Log.e("AÇÃO","CRIOU A INTENT");
        startActivity(t2);
        Log.e("AÇÃO","ABRIU TELA 2");

    }
}
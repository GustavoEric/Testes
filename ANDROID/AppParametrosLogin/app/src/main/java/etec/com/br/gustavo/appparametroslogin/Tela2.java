package etec.com.br.gustavo.appparametroslogin;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import org.w3c.dom.Text;

public class Tela2 extends AppCompatActivity {

    Button btSair;
    TextView tTela2Usuario,tTela2Senha;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela2);

        btSair = findViewById(R.id.btnSair);
        tTela2Usuario = findViewById(R.id.txtTela2);
        tTela2Senha = findViewById(R.id.txtTela2Senha);

        Intent telaAtual = getIntent();

        Bundle valoresRecebidos = telaAtual.getExtras();

        tTela2Usuario.setText(valoresRecebidos.getString("UsuarioCadastrado"));
        tTela2Senha.setText(valoresRecebidos.getString("SenhaCadastrado"));

        String Usuario,Senha;
        Usuario = valoresRecebidos.getString("UsuarioCadastrado");
        Senha = valoresRecebidos.getString("SenhaCadastrado");
        if (Usuario.equals("Gustavo") && Senha.equals("1234")){
            Toast.makeText(Tela2.this, "Bem Vindo Gustavo", Toast.LENGTH_SHORT).show();
        }
        else{
            Toast.makeText(Tela2.this, "Usuario Invalido", Toast.LENGTH_SHORT).show();
        }
    }
}
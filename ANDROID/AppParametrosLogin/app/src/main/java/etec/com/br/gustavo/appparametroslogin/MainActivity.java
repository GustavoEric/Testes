package etec.com.br.gustavo.appparametroslogin;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    Button  btLoga;
    EditText edUsuario,edSenha;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edUsuario = findViewById(R.id.edtUsuario);
        edSenha = findViewById(R.id.edtSenha);
        btLoga = findViewById(R.id.btnLoga);

        btLoga.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String usuario,senha;
                if (edUsuario.getText().toString().isEmpty()){
                    edUsuario.setError("Usuário Obrigatório");
                    edUsuario.requestFocus();
                }
                else if (edSenha.getText().toString().isEmpty()){
                    edSenha.setError("Senha Obrigatória");
                    edSenha.requestFocus();
                }
                else {
                    usuario = edUsuario.getText().toString();
                    senha = edSenha.getText().toString();

                    Intent tela2 = new Intent(MainActivity.this,Tela2.class);
                    tela2.putExtra("UsuarioCadastrado",usuario);
                    tela2.putExtra("SenhaCadastrado",senha);

                    startActivity(tela2);
                }
            }
        });
    }
}
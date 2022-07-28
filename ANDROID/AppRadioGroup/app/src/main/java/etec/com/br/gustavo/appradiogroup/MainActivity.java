package etec.com.br.gustavo.appradiogroup;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    //Atributos
    EditText edSalario;
    RadioGroup rgp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void calcularSalario (View v){
        float salario,novoSalario=0;

        edSalario = findViewById(R.id.edtSalario);
        rgp = findViewById(R.id.grpOpcoes);

        //Verificando se o Salário esta Vazio
        if(edSalario.getText().toString().length()<=0){
            edSalario.setError("Informe o salário");
        }
        else{
            //Guardando variavel do valor digitado
            //atraves de edtSalario
            salario = Float.parseFloat(edSalario.getText().toString());

            //variqvel OP para receber o RadioButton Clicado
            int op = rgp.getCheckedRadioButtonId();

            //Verificando qual radio foi selecionada e efetuando calculos

            if (op==R.id.rbt40){
                novoSalario = salario + (salario*0.40f);
            }
            else if (op==R.id.rbt45){
                novoSalario = salario + (salario*0.45f);
            }
            else{
                novoSalario = salario + (salario*0.50f);
            }
            //Exibindo em um TOAST
            //Toast.makeText(this, "Seu novo salário é : R$"+novoSalario, Toast.LENGTH_LONG).show();

            AlertDialog.Builder mensagem = new AlertDialog.Builder(this);
            mensagem.setTitle("Resultado");
            mensagem.setMessage("Seu novo salário é : R$"+novoSalario);
            mensagem.setNeutralButton("OK", null);
            mensagem.setCancelable(false);
            mensagem.show();
        }
    }
}
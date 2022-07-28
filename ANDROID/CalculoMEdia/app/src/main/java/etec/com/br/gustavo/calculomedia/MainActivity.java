package etec.com.br.gustavo.calculomedia;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    Button btCalcular;
    EditText edNota1,edNota2,edNota3;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edNota1=findViewById(R.id.edtNota1);
        edNota2=findViewById(R.id.edtNota2);
        edNota3=findViewById(R.id.edtNota3);
        btCalcular= findViewById(R.id.btnCalcular);

        btCalcular.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float n1,n2,n3,resultado;

                if (edNota1.getText().toString().isEmpty()){
                    edNota1.setError("Nota 1 Obrigatório");
                    edNota1.requestFocus();
                }
                else if (edNota2.getText().toString().isEmpty()){
                    edNota2.setError("Nota 2 Obrigatório");
                    edNota2.requestFocus();
                }
                else if (edNota3.getText().toString().isEmpty()){
                    edNota3.setError("Nota 3 Obrigatório");
                    edNota3.requestFocus();
                }
                else{
                    n1=Float.parseFloat(edNota1.getText().toString());
                    n2=Float.parseFloat(edNota2.getText().toString());
                    n3=Float.parseFloat(edNota3.getText().toString());

                    resultado=(n1+n2+n3)/3;

                    Toast.makeText(MainActivity.this, "Sua Média É: "+resultado, Toast.LENGTH_LONG).show();
                }
            }
        });
    }
}
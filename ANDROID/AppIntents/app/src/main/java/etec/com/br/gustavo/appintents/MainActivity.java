package etec.com.br.gustavo.appintents;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    Button btUm,btDois;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btUm=findViewById(R.id.btnT2);
        btDois=findViewById(R.id.btnT3);

        btUm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Intent Tela2 = new Intent(MainActivity.this, Tela2.class);
                startActivity(Tela2);
            }
        });

        btDois.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent Tela3 = new Intent(MainActivity.this, Tela3.class);
                startActivity(Tela3);
            }
        });
    }
}
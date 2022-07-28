package etec.com.gustavo.conversordetemperatura;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    //Referenciando Objetos JAVA
    Button btCelsiusKelvin,btKelvinCelsius,btCelsiusFahrenheit,btFahrenheitCelsius,btKelvinFahrenheit,btFahrenheitKelvin;
    EditText edTemp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        edTemp=findViewById(R.id.edtTemp);
        btCelsiusKelvin=findViewById(R.id.btnCelsiusKelvin);
        btKelvinCelsius=findViewById(R.id.btnKelvinCelsius);
        btCelsiusFahrenheit=findViewById(R.id.btnCelsiusFahrenheit);
        btFahrenheitCelsius=findViewById(R.id.btnFahrenheitCelsius);
        btKelvinFahrenheit=findViewById(R.id.btnKelvinFahrenheit);
        btFahrenheitKelvin=findViewById(R.id.btnFahrenheitKelvin);

        btCelsiusKelvin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=temperatura+273.15;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Kelvin é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });

        btKelvinCelsius.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=temperatura-273.15;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Celsius é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });

        btCelsiusFahrenheit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=(temperatura*1.8)+32;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Fahrenheit é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });

        btFahrenheitCelsius.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=(temperatura-32)*0.55555;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Celsius é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });

        btKelvinFahrenheit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=((temperatura-273.15)*1.8)+32;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Fahrenheint é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });

        btFahrenheitKelvin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                float temperatura;
                double resultado;
                if (edTemp.getText().toString().isEmpty()){
                    edTemp.setError("Temperatura Obrigatória");
                    edTemp.requestFocus();
                }
                temperatura=Float.parseFloat(edTemp.getText().toString());

                resultado=((temperatura-32)*0.55555)+273.15;

                Toast.makeText(MainActivity.this, "Sua Temperatura em Kelvin é: "+resultado, Toast.LENGTH_LONG).show();
            }
        });
    }
}
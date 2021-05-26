package com.example.appmnactec;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class score extends AppCompatActivity {
    Intent i,recibe;
    Bundle bolsa;
    int calificaion=0;
    ImageButton reg;
    TextView txt;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.score);
        reg= (ImageButton)findViewById(R.id.regresar);
        txt= (TextView) findViewById(R.id.score);
        i=new Intent(score.this, MenuJuego2.class);

        txt.setText("Puntuación: "+Pantallafinal.getPuntuacion());


        reg.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(i);
            }
        });
    }
}

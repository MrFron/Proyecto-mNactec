package com.example.appmnactec;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class Pantallafinal extends AppCompatActivity {
    private static int puntuacion;
    TextView pts,nom1;
    TextView nom_pre;
    Personatges lista_pre;
    ImageButton volver;
    ImageView img_pre;
    String nom_usu;
    Intent j;

    public static int getPuntuacion() {
        return puntuacion;
    }

    public static void setPuntuacion(int puntuacion) {
        Pantallafinal.puntuacion = puntuacion;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantallafinal);
        pts = (TextView)findViewById(R.id.puntuacion);
        pts.setText("Puntuació: "+puntuacion);
        volver=(ImageButton)findViewById(R.id.home);
        j=new Intent(Pantallafinal.this,MainActivity.class);

        volver.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                puntuacion = 0;
                startActivity(j);
            }
        });

        lista_pre = Json.leerJsonPersonajes();
        String nom = Personatges.assignarPersonatge(lista_pre,puntuacion);
        String imatge = Personatges.assignarPersonatgeImatge(lista_pre,puntuacion);

        nom_pre = (TextView) findViewById(R.id.nom_pre);
        nom_pre.setText(nom);

        img_pre = (ImageView)findViewById(R.id.img_pers);
        int id = getResources().getIdentifier(imatge,"drawable",getPackageName());
        img_pre.setImageResource(id);

        nom1 = (TextView)findViewById(R.id.nom_usu);
        nom1.setText(MainActivity.getNom_usu() + ", el teu personatge és: ");
    }
}

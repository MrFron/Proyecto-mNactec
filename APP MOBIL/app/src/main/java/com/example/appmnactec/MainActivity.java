package com.example.appmnactec;

import androidx.annotation.DrawableRes;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import android.Manifest;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.content.pm.PackageManager;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;

public class MainActivity extends AppCompatActivity {
    Boolean idi_pressed, dif_pressed;
    Intent k;
    EditText nom_usuari;
    private static String nom_usu;
    ImageButton menu,facil,dificil,medio,eng,esp,cat;
    public static int dificultad=0;
    public static String idioma ="";



    public static int getDificultad() {
        return dificultad;
    }


    public static String getIdioma() {
        return idioma;
    }


    public static String getNom_usu() {
        return nom_usu;
    }



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        k=new Intent(MainActivity.this,MenuJuego.class);
        menu=(ImageButton)findViewById(R.id.imageButtonPlay); menu.setEnabled(false);
        facil=(ImageButton)findViewById(R.id.buttonFacil);
        dificil=(ImageButton)findViewById(R.id.buttonDificil);
        medio=(ImageButton)findViewById(R.id.buttonMedio);
        cat=(ImageButton)findViewById(R.id.cat);
        esp=(ImageButton)findViewById(R.id.esp);
        eng=(ImageButton)findViewById(R.id.eng);
        nom_usuari = (EditText)findViewById(R.id.editText);



        menu.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(k);
                nom_usu = nom_usuari.getText().toString();
            }
        });




        eng.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                idioma="eng";
                eng.setImageResource(R.drawable.bandera_anglaterragris);
                cat.setImageResource(R.drawable.catala2);
                esp.setImageResource(R.drawable.bandera_spain);
                idi_pressed = true;

                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }
            }
        });
        esp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                idioma="esp";
                eng.setImageResource(R.drawable.bandera_anglaterra);
                cat.setImageResource(R.drawable.catala2);
                esp.setImageResource(R.drawable.bandera_spaingris);
                idi_pressed = true;
                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }

            }
        });
        cat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                idioma="cat";
                eng.setImageResource(R.drawable.bandera_anglaterra);
                cat.setImageResource(R.drawable.catala2gris);
                esp.setImageResource(R.drawable.bandera_spain);
                idi_pressed = true;
                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }

            }
        });




        medio.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {

                dificultad = 2;
                medio.setImageResource(R.drawable.mediumgris);
                facil.setImageResource(R.drawable.easy);
                dificil.setImageResource(R.drawable.hard);
                dif_pressed = true;
                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }
            }
        });
        dificil.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                medio.setImageResource(R.drawable.medium);
                facil.setImageResource(R.drawable.easy);
                dificil.setImageResource(R.drawable.hardgris);
                dificultad = 3;
                dif_pressed = true;
                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }

            }
        });
        facil.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                medio.setImageResource(R.drawable.medium);
                facil.setImageResource(R.drawable.easygris);
                dificil.setImageResource(R.drawable.hard);
                dificultad = 1;
                dif_pressed = true;
                if(dif_pressed == idi_pressed){
                    menu.setEnabled(true);
                }


            }
        });






    }
    public boolean acceptar(){
        boolean accept = false;
        if (android.os.Build.VERSION.SDK_INT >= 23)
        {
            // Si executem la versió Marshmallow (6.0) o posterior, haurem de demanar
            // permisos en temps d'execució

            // Comprovem si l'usuari ja ens ha donat permisos en una execió anterior
            if (ContextCompat.checkSelfPermission(this,
                    Manifest.permission.READ_EXTERNAL_STORAGE)
                    != PackageManager.PERMISSION_GRANTED)
            {

                // Si l'usuari no ens havia atorgat permisos, els hi demanem i
                // executem el nostre codi

                ActivityCompat.requestPermissions(this,
                        new String[]{Manifest.permission.READ_EXTERNAL_STORAGE},1);

                accept = true;
            }
            else
            {
                // Si l'usuari ja ens havia atorgat permisos en una execució anterior,
                // executem directament el nostre codi

                accept = true;            }
        }
        else
        {

            // Si executem una versió anterior a la versió Marshmallow (6.0),
            // no cal demanar cap permís, i podem executar el nostre codi directament

            accept = true;
        }
        return accept;
    }
}
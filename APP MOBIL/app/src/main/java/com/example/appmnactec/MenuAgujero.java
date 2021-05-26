package com.example.appmnactec;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;

import androidx.appcompat.app.AppCompatActivity;

public class MenuAgujero extends AppCompatActivity {
    Intent i,j;
    ImageButton iniciarjuego;
    ImageButton volver;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_juegoagujero);
        j=new Intent(MenuAgujero.this,MainActivity.class);
         volver=(ImageButton)findViewById(R.id.imageAtras);
         volver.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View view) {
                 Pantallafinal.setPuntuacion(0);
                 startActivity(j);
             }
         });

         i = new Intent(MenuAgujero.this, JuegoPlanetas.class);
         iniciarjuego=(ImageButton) findViewById(R.id.imagePlay);
         iniciarjuego.setOnClickListener(new View.OnClickListener() {
                     @Override
                     public void onClick(View view) {
                         startActivity(i);
             }
         });

    }



}

package com.example.appmnactec;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;

public class MenuJuego extends AppCompatActivity {
    Intent i,j;
    ImageButton iniciarjuego;
    ImageButton volver;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_juego);
         j=new Intent(MenuJuego.this,MainActivity.class);
         volver=(ImageButton)findViewById(R.id.imageAtras);
         volver.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View view) {
                 Pantallafinal.setPuntuacion(0);
                 startActivity(j);
             }
         });

         i = new Intent(MenuJuego.this, quiztierra.class);
         iniciarjuego=(ImageButton) findViewById(R.id.imagePlay);
         iniciarjuego.setOnClickListener(new View.OnClickListener() {
                     @Override
                     public void onClick(View view) {
                         startActivity(i);
             }
         });

    }
}

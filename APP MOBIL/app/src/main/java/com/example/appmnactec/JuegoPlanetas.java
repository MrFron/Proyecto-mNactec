package com.example.appmnactec;

import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.graphics.Color;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.text.Html;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

public class JuegoPlanetas extends AppCompatActivity {


    ImageView imagen;
    EditText respuesta;
    ImageButton ok;
    TextView puntos,missatge,contador;


    String[] imatges_pl={"terra","jupiter","mart","mercuri","neptu","saturn","ura","venus"};
    String[] imatges_pl2={"earth","jupiter","mars","mercury","neptune","saturn","uranus","venus"};
    String [] imatges_pl3={"tierra","júpiter","marte","mercurio","neptuno","saturno","urano","venus"};
    String[]imatges_nom={"img1","img2","img3","img4","img5","img6","img7","img8"};
    int punto=0,generat=0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_juegos_planetas);
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_LANDSCAPE);

        imagen = (ImageView) findViewById(R.id.img);
        respuesta = (EditText) findViewById(R.id.resposta);
        ok = (ImageButton) findViewById(R.id.buttonOK);
        puntos = (TextView) findViewById(R.id.Puntuacio);
        missatge = (TextView) findViewById(R.id.missatge);
        contador = (TextView) findViewById(R.id.contador);

        generarNUM(generat);

        ok.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                String resposta = respuesta.getText().toString().toLowerCase();

                if (resposta.equals(imatges_pl[generat]) | resposta.equals(imatges_pl2[generat]) | resposta.equals(imatges_pl3[generat])) {

                    missatge.setVisibility(View.VISIBLE);
                    missatge.setText("Correcte!");
                    missatge.setTextColor(Color.GREEN);
                    punto=punto+10;
                    puntos.setText("Puntuació: " + punto);
                    if(generat<7){
                    esperar();}else{acabar(generat); }
                }else{
                    missatge.setVisibility(View.VISIBLE);
                    missatge.setText("Inorrecte!");
                    missatge.setTextColor(Color.RED);
                    if(generat<7){
                        esperar();}else{acabar(generat); }
                }

            }

        });


    }




    void generarNUM(int num){
        int id = getResources().getIdentifier(imatges_nom[num],"drawable",getPackageName());
        imagen.setImageResource(id);
    }




    void esperar(){
        new CountDownTimer(2000,1) {
            @Override
            public void onTick(long milisUntilFinished) {
             contador.setText(""+(milisUntilFinished/1000+1));
             ok.setVisibility(View.GONE);
             respuesta.setText("");
            }

            @Override
            public void onFinish() {
                ok.setVisibility(View.VISIBLE);
                generat=generat+1;
                contador.setText("");
                generarNUM(generat);
                missatge.setVisibility(View.INVISIBLE);
            }
        }
        .start();




        }
        void acabar(int generat){

            if(generat ==7)

            {
                AlertDialog.Builder builder = new AlertDialog.Builder(JuegoPlanetas.this);
                builder.setTitle(Html.fromHtml("<big>FIN DEL JUEGO</big>"));
                builder.setMessage(Html.fromHtml("<big>SE TE VA A ASIGNAR UN PERSONAJE EN BASE A TU PUNTUACIÓN</big>"));
                builder.setPositiveButton(Html.fromHtml("<big>RESUMEN</big>"), new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        Intent intent = new Intent(JuegoPlanetas.this, Pantallafinal.class);
                        Pantallafinal.setPuntuacion(Pantallafinal.getPuntuacion()+punto);
                        startActivity(intent);
                    }
                });


                builder.show();
            }
        }
    }



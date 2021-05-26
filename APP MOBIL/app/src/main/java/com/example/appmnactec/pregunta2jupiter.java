package com.example.appmnactec;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class pregunta2jupiter extends AppCompatActivity implements View.OnClickListener {

    Preguntes lista;
    TextView pre;
    Button a,b,c,d;
    ImageButton sig;
    private static int calificaion= 0;
    Intent i,recibe;
    Bundle bolsa;
    int pos;
    @SuppressLint("WrongViewCast")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.pregunta2);
        i = new Intent(pregunta2jupiter.this, pregunta3jupiter.class);
        a = (Button)findViewById(R.id.a2);
        b = (Button)findViewById(R.id.b2);
        c = (Button)findViewById(R.id.c2);
        d = (Button)findViewById(R.id.d2);
        sig= (ImageButton)findViewById(R.id.sig2);
        pre = (TextView)findViewById(R.id.p2);




        a.setOnClickListener(this);
        b.setOnClickListener(this);
        c.setOnClickListener(this);
        d.setOnClickListener(this);
        sig.setOnClickListener(this);
        sig.setEnabled(false);


        lista = Json.leerJson();

        MainActivity main= new MainActivity();
        int dificultat = main.getDificultad();



        pos = Preguntes.buscarPre(lista,8,dificultat);

       rellenar();
    }

    public void rellenar(){
        int numero = (int) (Math.random() * 4) + 1;

        if(numero == 1){
            pre.setText(lista.getPreguntes().get(pos).getPregunta());
            a.setText(lista.getPreguntes().get(pos).getResposta());
            b.setText(lista.getPreguntes().get(pos).getOpcio2());
            c.setText(lista.getPreguntes().get(pos).getOpcio1());
            d.setText(lista.getPreguntes().get(pos).getOpcio3());
        }
        if(numero == 2){
            pre.setText(lista.getPreguntes().get(pos).getPregunta());
            a.setText(lista.getPreguntes().get(pos).getOpcio2());
            b.setText(lista.getPreguntes().get(pos).getResposta());
            c.setText(lista.getPreguntes().get(pos).getOpcio1());
            d.setText(lista.getPreguntes().get(pos).getOpcio3());
        }
        if(numero == 3){
            pre.setText(lista.getPreguntes().get(pos).getPregunta());
            a.setText(lista.getPreguntes().get(pos).getOpcio1());
            b.setText(lista.getPreguntes().get(pos).getOpcio2());
            c.setText(lista.getPreguntes().get(pos).getResposta());
            d.setText(lista.getPreguntes().get(pos).getOpcio3());
        }
        if(numero == 4){
            pre.setText(lista.getPreguntes().get(pos).getPregunta());
            a.setText(lista.getPreguntes().get(pos).getOpcio3());
            b.setText(lista.getPreguntes().get(pos).getOpcio2());
            c.setText(lista.getPreguntes().get(pos).getOpcio1());
            d.setText(lista.getPreguntes().get(pos).getResposta());
        }
    }

    @Override
    public void onClick(View v) {
        switch (v.getId()){
            case R.id.a2 :
                verificarA();
                break;
            case R.id.b2 ://Resposta correcte
                verificarB();
                break;
            case R.id.c2 :
                verificarC();
                break;
            case R.id.d2 :
                verificarD();
                break;
            case R.id.sig2 :
                startActivity(i);
                break;
            default:
                break;
        }


    }
    public void verificarA(){
        if(lista.getPreguntes().get(pos).getResposta()==a.getText()){
            Pantallafinal.setPuntuacion(Pantallafinal.getPuntuacion()+20);
            a.setBackgroundColor(Color.GREEN);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }else{
            a.setBackgroundColor(Color.RED);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }
    }
    public void verificarB(){
        if(lista.getPreguntes().get(pos).getResposta()==b.getText()){
            Pantallafinal.setPuntuacion(Pantallafinal.getPuntuacion()+20);
            b.setBackgroundColor(Color.GREEN);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }else{
            b.setBackgroundColor(Color.RED);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }
    }
    public void verificarC(){
        if(lista.getPreguntes().get(pos).getResposta()==c.getText()){
            Pantallafinal.setPuntuacion(Pantallafinal.getPuntuacion()+20);
            c.setBackgroundColor(Color.GREEN);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }else{
            c.setBackgroundColor(Color.RED);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }
    }
    public void verificarD(){
        if(lista.getPreguntes().get(pos).getResposta()==d.getText()){
            Pantallafinal.setPuntuacion(20);
            Pantallafinal.setPuntuacion(Pantallafinal.getPuntuacion()+20);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }else{
            d.setBackgroundColor(Color.RED);
            a.setEnabled(false);
            b.setEnabled(false);
            c.setEnabled(false);
            d.setEnabled(false);
            sig.setEnabled(true);
        }
    }
}

package com.example.appmnactec;

import android.os.Environment;

import com.google.gson.Gson;
import com.google.gson.JsonArray;
import com.google.gson.reflect.TypeToken;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class Json {


public static Preguntes leerJson() {
    Gson hola = new Gson();
    String dir = Environment.getExternalStorageDirectory().getAbsolutePath();

    if(MainActivity.getIdioma().equals("esp")){
        dir += "/Preguntes/Castellano_pre.json";
    }
    if(MainActivity.getIdioma().equals("cat")){
        dir += "/Preguntes/Catala_pre.json";
    }
    if (MainActivity.getIdioma().equals("eng")){
        dir += "/Preguntes/English_pre.json";
    }

    Preguntes lista = null;

    FileReader file;

    {
        try {
            file = new FileReader(dir);
            lista = new Gson().fromJson(file, Preguntes.class);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }
    return lista;
}
    public static Personatges leerJsonPersonajes() {
        Gson hola = new Gson();
        String dir = Environment.getExternalStorageDirectory().getAbsolutePath();

        dir += "/Personatges/Catala_pers.json";

        Personatges lista_pre =null;

        FileReader file;

        {
            try {
                file = new FileReader(dir);
                lista_pre = new Gson().fromJson(file, Personatges.class);
            } catch (FileNotFoundException e) {
                e.printStackTrace();
            }
        }
        return lista_pre;
    }


}
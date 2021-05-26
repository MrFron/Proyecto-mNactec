package com.example.appmnactec;

import java.util.ArrayList;

public class Personatges {

    private ArrayList<Personatge> personatges;

    public ArrayList<Personatge> getPersonatges() {
        return personatges;
    }

    public Personatges(ArrayList<Personatge> personatges) {
        this.personatges = personatges;
    }

    public static String assignarPersonatge(Personatges lista_pre, int puntuacio){
        String personatge="";


        for (int i = 0; i < lista_pre.getPersonatges().size(); i++) {
            if (puntuacio <= lista_pre.getPersonatges().get(i).getPuntmax() && puntuacio >= lista_pre.getPersonatges().get(i).getPuntmin()) {

                personatge = lista_pre.getPersonatges().get(i).getNom();

            }
        }


        return personatge;
    }
    public static String assignarPersonatgeImatge(Personatges lista_pre, int puntuacio){
        String imatge="";


        for (int i = 0; i < lista_pre.getPersonatges().size(); i++) {
            if (puntuacio <= lista_pre.getPersonatges().get(i).getPuntmax() && puntuacio >= lista_pre.getPersonatges().get(i).getPuntmin()) {

                imatge = lista_pre.getPersonatges().get(i).getImagen();

            }
        }


        return imatge;
    }
}

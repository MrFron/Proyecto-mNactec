package com.example.appmnactec;

import java.util.ArrayList;

public class Preguntes {

    private ArrayList<Pregunta> preguntes;

    public ArrayList<Pregunta> getPreguntes() {
        return preguntes;
    }

    public Preguntes(ArrayList<Pregunta> preguntes) {
        this.preguntes = preguntes;
    }

    public static int buscarPre(Preguntes lista, int pos, int dificultat) {
        int trobat=0;
        int ret = 0;
        for (int i = 0; i < lista.getPreguntes().size(); i++) {
            if (dificultat == lista.getPreguntes().get(i).getNivell()) {
                trobat++;
            }
            if(trobat == pos)
            {
                ret = i;
            }

        }
        return ret;
    }
}


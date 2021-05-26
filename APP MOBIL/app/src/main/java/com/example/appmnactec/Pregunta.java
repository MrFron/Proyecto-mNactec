package com.example.appmnactec;

import java.util.ArrayList;

public class Pregunta {
    private int nivell;
    private String pregunta;
    private String opcio1;
    private String opcio2;
    private String opcio3;
    private String resposta;

    public Pregunta(int nivell, String pregunta, String opcio1, String opcio2, String opcio3, String resposta) {
        this.nivell = nivell;
        this.pregunta = pregunta;
        this.opcio1 = opcio1;
        this.opcio2 = opcio2;
        this.opcio3 = opcio3;
        this.resposta = resposta;
    }

    public int getNivell() {
        return nivell;
    }

    public void setNivell(int nivell) {
        this.nivell = nivell;
    }

    public String getPregunta() {
        return pregunta;
    }

    public void setPregunta(String pregunta) {
        this.pregunta = pregunta;
    }

    public String getOpcio1() {
        return opcio1;
    }

    public void setOpcio1(String opcio1) {
        this.opcio1 = opcio1;
    }

    public String getOpcio2() {
        return opcio2;
    }

    public void setOpcio2(String opcio2) {
        this.opcio2 = opcio2;
    }

    public String getOpcio3() {
        return opcio3;
    }

    public void setOpcio3(String opcio3) {
        this.opcio3 = opcio3;
    }

    public String getResposta() {
        return resposta;
    }

    public void setResposta(String resposta) {
        this.resposta = resposta;
    }


    public String toString() {
        return pregunta;
    }
    public String mostaropcio1(){

        return opcio1;
    }
}

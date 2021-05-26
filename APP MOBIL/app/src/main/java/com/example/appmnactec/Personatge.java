package com.example.appmnactec;

public class Personatge {

    private String nom;
    private int puntmin;
    private int puntmax;
    private String imagen;

    public Personatge(String nom, int puntmin, int puntmax, String imagen) {
        this.nom = nom;
        this.puntmin = puntmin;
        this.puntmax = puntmax;
        this.imagen = imagen;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public int getPuntmin() {
        return puntmin;
    }

    public void setPuntmin(int puntmin) {
        this.puntmin = puntmin;
    }

    public int getPuntmax() {
        return puntmax;
    }

    public void setPuntmax(int puntmax) {
        this.puntmax = puntmax;
    }

    public String getImagen() {
        return imagen;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }


}

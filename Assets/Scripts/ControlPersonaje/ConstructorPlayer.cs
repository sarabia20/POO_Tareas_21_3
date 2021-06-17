using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPlayer 
{
    
    public int playerId;
    public string nombre;
    public int vida;
    public int sigilosidad;
    public int fe;
    private int daño;

    public ConstructorPlayer(int id, string n, int vida, int f, int sigi)
    {
        this.playerId = id;
        this.nombre =n;
        this.vida = vida;
        this.fe = f;
        this.sigilosidad = sigi;
    }

   

    //Metodos y Comportamientos 

}


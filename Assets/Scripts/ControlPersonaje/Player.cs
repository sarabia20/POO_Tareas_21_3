using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
   public int playerId;
   public string nombre;
   public float vida;
   public float fe;
   public float sigilosidad;
   
    BasePlayer bdJugador;

   private void Start()
   {
    bdJugador=GameObject.FindObjectOfType<BasePlayer>();

    CargarDatos(playerId);
   }


   void CargarDatos(int id)
   { 
      for (int i = 0; i <bdJugador.nuevoJugador.Length; i++)
      {
         if (bdJugador.nuevoJugador[i].playerId==id)
         {
            this.nombre= bdJugador.nuevoJugador[i].nombre;
            this.vida= bdJugador.nuevoJugador[i].vida;
            this.fe= bdJugador.nuevoJugador[i].fe;
            this.sigilosidad= bdJugador.nuevoJugador[i].sigilosidad;
         }
      }
   }
}

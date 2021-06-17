using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionItem : MonoBehaviour
{

    public float playerPlus;
    
    private void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PoderJugador>().SumaFe(playerPlus);
        }
        
        
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PoderJugador>().SumaSigilosidad(playerPlus);
        }


    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderJugador : MonoBehaviour
{
    Player playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();
    }

    public void SumaFe (float fe)
    {
      playerData.fe += fe;
    }
    
    
    public void SumaSigilosidad (float sigilosidad)
    {
      playerData.sigilosidad += sigilosidad;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoJugador : MonoBehaviour
{
    
    Player playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();
    }

    // Update is called once per frame
    
    public void damage(float daño)
    {
       playerData.vida -= daño;
    }


}



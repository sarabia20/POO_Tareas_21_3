using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public ConstructorPlayer[] nuevoJugador;
    
    // Start is called before the first frame update
    void Awake()
    {
        nuevoJugador = new ConstructorPlayer [1];

        nuevoJugador[0] = new ConstructorPlayer(1,"Sofí",10,5,0);

    }

    
}


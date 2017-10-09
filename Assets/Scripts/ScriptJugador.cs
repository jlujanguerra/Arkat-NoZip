using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugador : MonoBehaviour {


    public float velocidadJugador;
    private Vector3 posicionJugador;
    public float limite;
    private int VidasJugador;
    private int PuntosJugador;
   

    // Use this for initialization
    void Start () {
        posicionJugador = gameObject.transform.position;
        VidasJugador = 3;
        PuntosJugador = 0;
        

    }
	
    
	// Update is called once per frame
	void Update () {
        posicionJugador.x += Input.GetAxis("Horizontal") * velocidadJugador;

        transform.position = posicionJugador;

   

        if (posicionJugador.x < -limite)
        {
            transform.position = new Vector3(-limite, posicionJugador.y, posicionJugador.z);
        }
        if (posicionJugador.x > limite)
        {
            transform.position = new Vector3(limite, posicionJugador.y, posicionJugador.z);
        }

        if (VidasJugador == 0)
        {
            

        }
    }

    void Agregarpuntos(int puntos)
    {
        PuntosJugador += puntos;
    }

     void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 3.0f, 200.0f, 200.0f), "Vidas: " + VidasJugador);
        GUI.Label(new Rect(5.0f, 20.0f, 200.0f, 200.0f), "Puntaje: " + PuntosJugador);
    }



    void QuitarVida()
    {
        VidasJugador--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBola : MonoBehaviour {

    private bool bolaActiva;
    private Vector3 posicionBola;
    private Vector2 BolaFInicial;

    public GameObject playerObject;

    // Use this for initialization
    void Start () {
        BolaFInicial = new Vector2(150.0f, 200.0f);
        bolaActiva = false;
        posicionBola = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump") == true)
        {
            
            if (!bolaActiva)
            {

                GetComponent<Rigidbody2D>().isKinematic = false;

                GetComponent<Rigidbody2D>().AddForce(BolaFInicial);

                bolaActiva = !bolaActiva;
            }


        }

        if (!bolaActiva && playerObject != null)
        {
           
            posicionBola.x = playerObject.transform.position.x;

            
            transform.position = posicionBola;
        }

        if (bolaActiva && transform.position.y < -6)
        {
            bolaActiva = !bolaActiva;
            posicionBola.x = playerObject.transform.position.x;
            posicionBola.y = -4.2f;
            transform.position = posicionBola;

            GetComponent<Rigidbody2D>().isKinematic = true;

            playerObject.SendMessage("QuitarVida");
        }

    }
}

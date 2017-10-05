using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorBarra : MonoBehaviour {

    public float VelocidadJugadorBarra;
    public Vector3 PosicionJugadorBarra; 

	//Use this for initialization
	void Start () {

       PosicionJugadorBarra = gameObject.transform.position;
        VelocidadJugadorBarra = 200;
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
        {
            
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(VelocidadJugadorBarra,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-VelocidadJugadorBarra, 0);
        }
        if (!Input.GetKey(KeyCode.RightArrow)&& !Input.GetKey(KeyCode.LeftArrow)&&!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
	}
}

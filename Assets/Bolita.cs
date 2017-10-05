using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolita : MonoBehaviour {
    float velMax;
    Rigidbody2D rigi;
    // Use this for initialization
    void Start() {
        rigi = gameObject.GetComponent<Rigidbody2D>();
        velMax = 200;

        rigi.velocity = new Vector2(0, -50);
	}

    // Update is called once per frame
    void Update() {

        if (rigi.velocity.x > velMax)
        {
            rigi.velocity = new Vector2(velMax, rigi.velocity.y);
        }
        if (rigi.velocity.y > velMax)
        {
            rigi.velocity = new Vector2(rigi.velocity.x, velMax);
        }
        if (rigi.velocity.x < -velMax)
        {
            rigi.velocity = new Vector2(-velMax, rigi.velocity.y);
        }
        if (rigi.velocity.y < -velMax)
        {
            rigi.velocity = new Vector2(rigi.velocity.x, -velMax);
        }
    }

}

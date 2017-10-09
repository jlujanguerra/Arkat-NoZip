using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PAuseButton : MonoBehaviour {
    bool hayPausa;
    public Canvas menuPausa;
    public GameObject tienda;
    public Text textLanitas;
    int lanitas;
    public SpriteRenderer spriteJugador;
    public Sprite algo;
    
    public void BotonTienda()
    {
            tienda.gameObject.SetActive(true);
    }

    public void BotonSalirTienda()
    {
        tienda.gameObject.SetActive(false);
    }

    public void CambiarSkin()
    {
        if (lanitas>=100)
        {
            lanitas = lanitas-100;
            spriteJugador.sprite = algo;
            
        }
        else
        {
            Debug.Log("Oye, no te alcanza para eso!");
        }
    }

    public void BotonPausa()
    {
        if (!hayPausa)
        {
            Time.timeScale = 0;
            hayPausa = true;
            menuPausa.gameObject.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            hayPausa = false;
            menuPausa.gameObject.SetActive(false);
        }
    }

	// Use this for initialization
	void Start () {
        hayPausa = false;
        lanitas = 200;
	}
	
	// Update is called once per frame
	void Update () {
        textLanitas.text = lanitas.ToString();
	}
}

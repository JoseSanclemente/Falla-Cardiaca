﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generacionGuia8 : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * -velocidad * Time.deltaTime;

        if (contador == 2)
        {

            adentro = true;

        }
        else
        {
            adentro = false;
        }

        if (GameObject.Find("leaf7").GetComponent<trigger>().ubicacion == "leaf7")
        {
            if (adentro)
            {
                GameObject.Find("finalRuta").GetComponent<logicaScore>().puntaje++;
                GameObject.Find("finalRuta").GetComponent<logicaScore>().texto.text = "Score: " +
                    GameObject.Find("finalRuta").GetComponent<logicaScore>().puntaje.ToString();

                Destroy(gameObject);
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            contador++;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            contador--;
        }
    }
}
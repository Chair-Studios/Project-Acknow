using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class TokenControler : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collider2d)
	{
		if(collider2d.tag == ("Player"))
		{

            FindObjectOfType<ScoreController>().Points(1f);
            Debug.Log("Collision");
            
            gameObject.SetActive(false);
        }

    }

    private void Start()
    {
        Random rand = new Random();

        //generate random colors with a small margin (so no totaly black or totally White)
        float red = (float)rand.NextDouble();
        float blue = (float)rand.NextDouble();
        float green = (float)rand.NextDouble();

        Color randColor = new Color(red, blue, green, 1);



        gameObject.GetComponent<Renderer>().material.color = randColor;

        FindObjectOfType<ScoreController>().Total();
    }
}

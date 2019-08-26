using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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
        Color randomColor = RandomColor();

        gameObject.GetComponent<Renderer>().material.color = randomColor;
        

        FindObjectOfType<ScoreController>().Total();
    }

    Color RandomColor()
    {
        // A different random value is used for each color component (if
        // the same is used for R, G and B, a shade of grey is produced).
        return new Color(Random.value, Random.value, Random.value);
    }
}

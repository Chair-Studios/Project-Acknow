using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
        FindObjectOfType<ScoreController>().Total();
    }
}

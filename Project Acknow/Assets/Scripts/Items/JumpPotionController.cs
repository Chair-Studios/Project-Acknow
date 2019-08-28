using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPotionController : MonoBehaviour
{
	public Rigidbody2D rb;
	public Rigidbody2D rb2;


	private void OnTriggerEnter2D(Collider2D collider2d)
	{
		if (collider2d.tag == ("Player"))
		{
			// set jump force to higher
			rb.AddForce(new Vector2(0f, 1500f));
			rb2.AddForce(new Vector2(0f, 1500f));
            
			gameObject.SetActive(false);

			Debug.Log("Collsion");
		}
	}

  

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPotionController : MonoBehaviour
{


	private void OnTriggerEnter2D(Collider2D collider2d)
	{
		if (collider2d.tag == ("Player"))
		{
            // set jump force to higher
            FindObjectOfType<CharacterController2D>().AddJumpForce(1600f);

            gameObject.SetActive(false);
		}
	}


		void Update()
    {
        
    }
}

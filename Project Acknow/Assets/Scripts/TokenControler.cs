using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenControler : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collider2d)
	{
		if(collider2d.tag == ("Player"))
		{
			Debug.Log("Collision");
		}
		
	}
}

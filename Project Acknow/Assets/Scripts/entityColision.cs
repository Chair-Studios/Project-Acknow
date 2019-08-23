using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entityColision : MonoBehaviour
{

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Collsion");
	}

}



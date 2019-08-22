using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repspawn : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
		// check if dead
		if (gameObject.transform.position.y < -10)
		{
			Debug.Log("under world");
			UnityEngine.SceneManagement.SceneManager.LoadScene("scene");

		}
	}
}

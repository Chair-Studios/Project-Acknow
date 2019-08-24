using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repspawn : MonoBehaviour
{
	public GameObject player1, player2;
    // Update is called once per frame
    void FixedUpdate()
    {
		// check if dead
		if (player1.transform.position.y < gameObject.transform.position.y || player2.transform.position.y < gameObject.transform.position.y)
		{
			Debug.Log("under world");
			UnityEngine.SceneManagement.SceneManager.LoadScene("scene");

		}
	}
}

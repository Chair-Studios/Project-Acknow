using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
	public GameObject cam1, cam2;

	bool toggle = false;

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.F))
		{
			if (toggle == true)
			{
				toggle = false;
				cam1.SetActive(true);
				cam2.SetActive(false);
				Debug.Log("Cam1");
			}
			else
			{
				toggle = true;
				cam1.SetActive(false);
				cam2.SetActive(true);
				Debug.Log("Cam2");
			}
		}

	}
}

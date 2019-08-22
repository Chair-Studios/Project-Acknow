using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimentionControler : MonoBehaviour
{
	public GameObject cam1, cam2;

	bool toggle = false;

	void FixedUpdate()
    {
		if (Input.GetKey(KeyCode.F))
		{
			if (toggle == true)
			{
				toggle = false;
				cam1.SetActive(true);
				cam2.SetActive(false);
			}
			else
			{
				toggle = true;
				cam1.SetActive(true);
				cam2.SetActive(false);
			}
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimentionControler : MonoBehaviour
{
	float dimention = 0;

	void FixedUpdate()
    {
		//NEED TO MAKE DIMENTION READ AND WRITEs
		if (Input.GetKey(KeyCode.Q) && dimention > 0f)
		{
            dimention = dimention - 1;
		}

		if (Input.GetKey(KeyCode.E) && dimention < 0f)
		{
            dimention = dimention + 1;
		}
	}
}

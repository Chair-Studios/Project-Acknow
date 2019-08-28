using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller2D;

	float HorizontalMove;
	bool Jump = false;
    bool Crouch = false;
    public float RunSpeed = 40f;

	private void FixedUpdate()
	{
		HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

		Jump = Input.GetKey(KeyCode.Space);
	
		Crouch = Input.GetKey(KeyCode.LeftShift);

        if (Crouch)
        {
            Jump = false;
        }

		controller2D.Move(HorizontalMove * Time.fixedDeltaTime , Crouch, Jump);
	}

	
}

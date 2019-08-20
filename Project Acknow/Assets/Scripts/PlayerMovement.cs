﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller2D;

	float HorizontalMove = 0f;
	bool Jump = false;
    public float RunSpeed = 40f;

	void Update()
    {
		HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		Jump = Input.GetKey(KeyCode.Space);
    }

	private void FixedUpdate()
	{
		controller2D.Move(HorizontalMove * Time.fixedDeltaTime , false, Jump);
	}
}

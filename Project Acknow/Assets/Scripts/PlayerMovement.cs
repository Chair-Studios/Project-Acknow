using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller2D;

	float HorizontalMove = 0f;
	bool Jump = false;
    bool Crouch = false;
    public float RunSpeed = 40f;

	void Update()
    {
		HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;
		Jump = Input.GetKey(KeyCode.Space);
        Crouch = Input.GetKey(KeyCode.LeftShift);

        // check if dead
        if (gameObject.transform.position.y < -10)
        {
            Debug.Log("under world");
            UnityEngine.SceneManagement.SceneManager.LoadScene("scene");

        }

    }

	private void FixedUpdate()
	{
        if (Crouch)
        {
            Jump = false;
        }
		controller2D.Move(HorizontalMove * Time.fixedDeltaTime , Crouch, Jump);
	}
}

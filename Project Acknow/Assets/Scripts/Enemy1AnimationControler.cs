using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1AnimationControler : MonoBehaviour
{
	Animator animator;
    void Start()
    {
		animator = GetComponent<Animator>();
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			animator.SetBool("Attacking", true);
		}
		
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		animator.SetBool("Attacking", false);
	}
}

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

	public void AttackAnim(bool atk)
	{
		animator.SetBool("Attacking", atk);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			FindObjectOfType<HealthController>().HealthAdd(-1f);

			AttackAnim(true);
		}
		
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		AttackAnim(false);
	}
}

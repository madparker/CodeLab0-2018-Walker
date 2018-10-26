using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : MonoBehaviour
{

	public Animator animator;

	void OnTriggerEnter(Collider other)
	{
		animator.SetBool("StartPlatform", true);
	}
}

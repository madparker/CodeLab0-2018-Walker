using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class StopPlatform : MonoBehaviour
{

	public Animator anim;

	void StopAnimation()
	{
		anim.SetBool("StartPlatform", false);
	}
}

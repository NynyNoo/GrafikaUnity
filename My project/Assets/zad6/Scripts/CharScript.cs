using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharScript : MonoBehaviour {

	private Animator animator;
	private bool m_Jump;
	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	void Update () {
		m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
		animator.SetBool("Nodding", m_Jump);
	}
}

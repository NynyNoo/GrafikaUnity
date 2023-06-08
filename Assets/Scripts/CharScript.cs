using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CharScript : MonoBehaviour {

	private Animator animator;
	private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
		animator.SetBool("Nodding", m_Jump);
	}
}

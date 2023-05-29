using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {
	public GameObject door;
	public bool open;
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = door.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Collider>().CompareTag("Player"))
		{
			animator.SetBool("Open", open);
		}
	}
}

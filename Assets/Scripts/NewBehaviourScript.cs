using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

public float speed;
public Text countText;
private int count;


// Use this for initialization
void Start () {
	count = 0;
	SetCountText ();
}


// Update is called once per frame
void Update () {
	//Input
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");

	//Move body
	Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	//-smooth movement
	GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
}


void OnTriggerEnter(Collider other) {
	//Cube objects
	if (other.gameObject.tag == "PickupCube") {
		other.gameObject.SetActive (false);
		count += 1;
		SetCountText ();
	}

	//Sphere objects
	else if (other.gameObject.tag == "PickupSphere") {
		other.gameObject.SetActive (false);
		count += 2;
		SetCountText ();
	}
}


void SetCountText ()
{
	countText.text = "Count: " + count.ToString ();
	if (count >= 10)
	{
		countText.text = "You Win!";
	}
}
}

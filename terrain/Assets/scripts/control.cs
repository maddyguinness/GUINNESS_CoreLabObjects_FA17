using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	//declare a variable for speed e.g. a float , then name that float as say moveSpeed, 
	// public makes it contorllable in unity 
	public float moveSpeed;
	public float moveAround;


	// Use this for initialization
	// under start you define the value of your variable float 
	void Start () {
		//moveSpeed = 5f;
		//moveAround = 1f;
	}

	// Update is called once per frame

	void Update () {

		float move = Input.GetAxisRaw("Vertical") *2f;
		float rotate = Input.GetAxisRaw("Horizontal") *2f;

		transform.Translate(move,0,0);

		transform.Rotate(rotate,0,0);
	}    
}
	// f after a decimal to say its a float)

	//input.GetAxisRaw (horizontal) or (Verticle) -1,0,1

	//say move speed is 2 you times that by the 1 and get 2 
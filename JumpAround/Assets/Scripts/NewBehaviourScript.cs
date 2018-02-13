using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ***Note***: This is not a C# program. This is a C# script. The key difference is that we do not have a Main(),
// but a Start() method.

// ***Note 2***: You can deal with this script if you open the project in visual studio.
public class NewBehaviourScript : MonoBehaviour
{

	// Use this for initialization
	// This method makes the script run when the game starts.
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	// If we want to make something happen in the game while we are playing it, we need
	// to put it in the Update() method.
	// This method is called a lot of times each second.
	void Update ()
	{
		// Storing the Rigidbody 2D component in a variable.
		// Used GetComponent to assign it with the physics component (Rigidbody 2D).
		// Note that GetComponent takes in a generic, which in this case, is a type Rigidbody2D object.
		var rigidBody = GetComponent<Rigidbody2D> ();
		if (Input.GetKey("right")) {
			// Debug.Log () prints a message on the console at Unity.
			Debug.Log("The right arrow was pressed!");
		}
	}
}
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
		var rigidBody = GetComponent<Rigidbody2D>();
        var transform = GetComponent<Transform>();

        // This is to create an action to move the object to the right by pressing the right arrow key.
		if (Input.GetKey("right")) {
            // Assigning a new velocity to rigidBody variable by using a structure called Vector2.
            // First parameter is the vector's x value, second parameter is the vector's y value.
            rigidBody.velocity = new Vector2(5, 0);
		}

        // This is to create an action to move the object to the left by pressing the left arrow key.
        if (Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(-5, 0);
            //rigidBody.velocity.x
        }

        if (Input.GetKeyDown("space"))
        {
            rigidBody.velocity = new Vector2(0, 10);
        }

        if (transform.position.y < -6)
        {
            if (transform.position.x < 2)
            {
                transform.position = new Vector2(-10, 0);
            } else
            {
                transform.position = new Vector2(10, 0);
            }
            
        }

        /*
        if (transform.position.x > 2)
        {
            transform.position = new Vector2(10, 1);
        }
        */
	}
}
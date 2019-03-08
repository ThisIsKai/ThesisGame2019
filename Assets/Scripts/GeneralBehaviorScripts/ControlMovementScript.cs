using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovementScript : MonoBehaviour
{

	public float bottomLimit;
	public float topLimit;
	[SerializeField] 																// makes it editable in the inspector
	bool isRight;																	// is it the Right Control

	[SerializeField] 																// makes it editable in the inspector
	float up_Speed = 0.2f;

    [SerializeField]                                                                // makes it editable in the inspector                                                                          // control speed
    float down_Speed = 0.2f;

	Transform myTransform;															// reference to the object's transform
	int direction = 0; 																// 0 = not moving, 1= up, -1 = down
	private Rigidbody rb; 															// rigidbody is rb now


	void Start () {																	// Start function
		myTransform = transform; 													// define myTransform
		rb = GetComponent<Rigidbody>(); 											// get that rigidbody
	//	col = GetComponent<CapsuleCollider2D>();									// get that collider
	}//END START


	void FixedUpdate () 
    {                                                           // FixedUpdate is called once per physics tick/frame
                                                                //rb.isKinematic = false;

        if (isRight)
        {
            if (Input.GetKey(KeyCode.O) || Input.GetKey(KeyCode.L))
            {
                rb.isKinematic = false;                                                             // is this the right control?
                if (Input.GetKey(KeyCode.O))                                            // make 'O' the up key for right control
                    MoveUp();                                                           // call move up
                else if (Input.GetKey(KeyCode.L))                                       // make 'L' the down key for right control
                    MoveDown();
            }
            else
                rb.isKinematic = true;                                                      // call move down
                                                                                            //else {																	// else
                                                                                            //	rb.velocity = Vector3.zero; 										// otherwise don't move
                                                                                            //} // end else not moving
        } // end right side control scheme

        else
        {
            if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.A))
            {
                rb.isKinematic = false;                                                         // if it's not right control (making it left)
                if (Input.GetKey(KeyCode.Q))                                            // make 'Q' the up key for the left control
                    MoveUp();                                                           // call move up
                else if (Input.GetKey(KeyCode.A))                                       // make 'A' the down key for left control
                    MoveDown();                                                         // call move down
                                                                                        //else {																	// else
                                                                                        //	rb.velocity = Vector3.zero;											// otherwise don't move
                                                                                        //} // end else not moving
            } // end left side control scheme
            else
                rb.isKinematic = true;
        }
        //else { rb.isKinematic = true; }
    } // END FIXED UPDATE

	void MoveUp() { 																// MoveUp function, to move control up, effected by 'speed'
		if (rb.transform.position.y <= topLimit) {
            Vector3 movementForce = new Vector3(0, up_Speed, 0);
            rb.AddForce(movementForce, ForceMode.Force); //toggle kinematic

			//Debug.Log("moving up");
			//Debug.Log(rb.velocity + "is up velocity");
		}//if in range
	}//END MOVE UP

	void MoveDown() {																// MoveDown function, to move control down, effected by 'speed'
		if (rb.transform.position.y >= bottomLimit) {
            Vector3 movementForce = new Vector3(0, -down_Speed, 0);
            rb.AddForce(movementForce, ForceMode.Force);
            //rb.velocity += new Vector3(0, -speed, 0); // simplified downwards momvement
            //rb.MovePosition(transform.position - new Vector3(0, speed, 0));
            //Debug.Log("moving down");
            //Debug.Log(rb.velocity + "is down velocity");
        }//end if in range
	}//END MOVE DOWN
		
}//END SCRIPT
using UnityEngine;
using System.Collections;

public class Flippers : MonoBehaviour
{
	public int forceApplied;
	public GameObject leftFlipper;
	public GameObject rightFlipper;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z)) {
			leftFlipper.transform.rigidbody.AddForce (0, 0, Time.deltaTime * forceApplied);	
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			rightFlipper.transform.rigidbody.AddForce (0, 0, Time.deltaTime * forceApplied);	
		}
	}
}

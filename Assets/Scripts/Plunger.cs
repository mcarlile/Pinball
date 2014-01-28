using UnityEngine;
using System.Collections;

public class Plunger : MonoBehaviour
{
	public int forceApplied;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			transform.rigidbody.AddForce (0, 0, Time.deltaTime * forceApplied);	
		}
	}
}

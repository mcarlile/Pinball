using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{

		public int forceApplied;
		public GameObject manager;
		public GameObject light;
		public int lightTime;


		// Use this for initialization
		void Start ()
		{
				manager = GameObject.Find ("Manager");
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerEnter (Collider otherCollider)
		{
				if (otherCollider.gameObject.name.Contains ("Ball")) {
						otherCollider.rigidbody.velocity = -otherCollider.rigidbody.velocity * forceApplied;
						manager.GetComponent<Manager> ().IncrementScore ();
				}
		}

		void OnTriggerStay (Collider otherCollider)
		{
				if (otherCollider.gameObject.name.Contains ("Ball")) {
						light.SetActive (true);
						Debug.Log ("I'm being hit");
				}
		}

		void OnTriggerExit (Collider otherCollider)
		{
				if (otherCollider.gameObject.name.Contains ("Ball")) {
						light.SetActive (false);
				}
		}
}

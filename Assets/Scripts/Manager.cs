using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

		public int balls = 3;
		public int score = 0;
		public int scoreValue = 10;
		public TextMesh ballIndicator;
		public TextMesh scoreIndicator;
		public GameObject ballIndicatorObject;
		public GameObject scoreIndicatorObject;
		public GameObject ballPrefab;
		public GameObject ballSpawnPoint;
		public GameObject gameOver;

		// Use this for initialization
		void Start ()
		{
				SpawnBall ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				ballIndicator.GetComponent<TextMesh> ().text = "Balls: " + balls;
				scoreIndicator.GetComponent<TextMesh> ().text = "Score: " + score;
				if (balls < 1) {
						gameOver.SetActive (true);
						ballIndicatorObject.SetActive (false);
						scoreIndicatorObject.SetActive (false);

						if (Input.GetKey (KeyCode.Escape)) {
								Application.LoadLevel (0);
						}
				}
		}

		public void DecrementBalls ()
		{
				balls--;
		}

		public void IncrementScore ()
		{
				score = score + scoreValue;
		}

		public void SpawnBall ()
		{
				if (balls > 0) {
						Instantiate (ballPrefab, ballSpawnPoint.transform.position, Quaternion.identity);
						Debug.Log ("Ball is being spawned");
				}
		}
}

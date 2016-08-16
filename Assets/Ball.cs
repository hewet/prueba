using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	int speedX;
	int speedY;

	float speed;


	// Use this for initialization
	void Start () {
	
		speed = Random.Range (5, 10);

		speedX = Random.Range (0, 2);
		if (speedX == 0) {
			speedX = 1;
		} else {
			speedX = -1;
		}

		speedY = Random.Range (0, 2);
		if (speedY == 0) {
			speedY = 1;
		} else {
			speedY = -1;
		}

		GetComponent<Rigidbody> ().velocity = new Vector3 (speed * speedX, speed * speedY, 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

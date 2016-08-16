using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	/*
	public KeyCode up;
	public KeyCode down;
*/
	float speed = 0.3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float way = Input.GetAxis (this.name);

		transform.Translate (0, speed* way, 0);

	/*
		if (Input.GetKey (up)) {
			transform.Translate (0, speed, 0);
		}

		if (Input.GetKey (down)) {
			transform.Translate (0, -speed, 0);
		}
*/
	}
}

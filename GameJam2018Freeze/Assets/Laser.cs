using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	bool laserOn = false;
	public Transform startPoint;
	public Transform endPoint;
	LineRenderer laser;

	private float counter;
	public float distance;

	public float lineSpeed = 4f;

	// Use this for initialization
	void Start () {
		laser = GetComponent<LineRenderer> ();
		laser.SetWidth (0.7f, 0.7f);
	}
	
	// Update is called once per frame
	void Update () {
		laser.SetPosition (0, startPoint.position);
		laser.SetPosition (1, endPoint.position);
		distance = Vector3.Distance (startPoint.position, endPoint.position);

		counter = counter + 0.1f / lineSpeed;

		float x = Mathf.Lerp (0, distance, counter);

		Vector3 pointOnLine = x * Vector3.Normalize (endPoint.position - startPoint.position) + startPoint.position;

		laser.SetPosition (1,pointOnLine);
	}

	void turnLaserOn(){
		laserOn = true;
	}


}

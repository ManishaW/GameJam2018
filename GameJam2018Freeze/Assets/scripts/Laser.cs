using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	bool laserOn = false;
	bool firstLaser = true;
	public Transform startPoint;
	public Transform endPoint;
	LineRenderer laser;

	private float counter;
	public float distance;

	public float lineSpeed = 4f;
	float laserTime = 8f;

	// Use this for initialization
	void Start () {
		laser = GetComponent<LineRenderer> ();

	}
	
	// Update is called once per frame
	void Update () { 

		laserTime = laserTime - Time.deltaTime;
		Debug.Log (laserTime);

		if ((!laserOn && laserTime <= 0f) || firstLaser) {

			laserTime = 8;
			laser.enabled = true;
			turnLaserOn ();

			laser.SetPosition (0, startPoint.position);
			laser.SetPosition (1, endPoint.position);
			distance = Vector3.Distance (startPoint.position, endPoint.position);

			counter = counter + 0.1f / lineSpeed;

			float x = Mathf.Lerp (0, distance, counter);

			Vector3 pointOnLine = endPoint.position;//x * Vector3.Normalize (endPoint.position - startPoint.position) + startPoint.position;

			laser.SetPosition (1, pointOnLine);

			firstLaser = false;

		}

	}

	void turnLaserOn(){
		laserOn = true;
		StartCoroutine(Blink(4, 0.2f, 0.23f));
	}

	IEnumerator Blink(int nTimes, float timeOn, float timeOff){
		yield return new WaitForSeconds(3f);

		while (nTimes > 0){
			laser.enabled = true;
			yield return new WaitForSeconds(timeOn);
			laser.enabled = false;
			yield return new WaitForSeconds(timeOff);
			nTimes--;
		}
		laserOn = false;

	}

	bool isLaserOn(){
		return laserOn;
	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject.tag == "Player" && isLaserOn()){

			GameObject canvas = GameObject.Find ("gameOverCanvas");
			canvas.SetActive (true);
		}
	}
}

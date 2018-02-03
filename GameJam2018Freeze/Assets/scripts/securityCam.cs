using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class securityCam : MonoBehaviour {
	public GameObject character;
	public GameObject securityOverlay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("cam got uuu");
		if (Input.touchCount>0) {
			Debug.Log ("but im frozen");
			//if not moving, overlay canvas
			securityOverlay.SetActive(true);
		} else {
			//game over
			Debug.Log("Game over");
		}


	}
	void OnTriggerStay(Collider other)
	{
		if (Input.touchCount>0) {
			Debug.Log ("but im frozen");
			//if not moving, overlay canvas
			securityOverlay.SetActive(true);
		} else {
			//game over
			Debug.Log("Game over");
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		securityOverlay.SetActive(false);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour {

	bool cameraGoing = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount>0) || !cameraGoing) {
		} else {
			float step = 7;

			var cameraPosition = Camera.main.gameObject.transform.position;
			cameraPosition.x += step;
			Camera.main.gameObject.transform.position = cameraPosition;
		}

		}

	public void scrollCamera(bool s){
		cameraGoing = s;
	}
}

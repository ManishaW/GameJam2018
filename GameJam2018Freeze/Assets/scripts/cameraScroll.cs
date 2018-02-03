using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount>0)) {
		} else {
			float step = 4;

			var cameraPosition = Camera.main.gameObject.transform.position;
			cameraPosition.x += step;
			Camera.main.gameObject.transform.position = cameraPosition;
		}

		}


}

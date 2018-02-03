using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAuto : MonoBehaviour {
	public GameObject character;
	Vector3 old_pos;
	// Use this for initialization
	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.touchCount>0) {
		} else {
			character.transform.Translate(Vector2.right * 7.5f);
		}

	}
}

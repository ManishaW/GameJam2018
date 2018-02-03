using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAuto : MonoBehaviour {
	public GameObject character;
	Vector3 old_pos;

	private Animator burglarAnim;

	// Use this for initialization
	void Start () {	

		burglarAnim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.touchCount>0) {
			burglarAnim.SetBool ("walking", false);

		} else {
			character.transform.Translate(Vector2.right * 7f);
		}

	}
}

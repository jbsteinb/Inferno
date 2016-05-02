using UnityEngine;
using System.Collections;

public class CameraLimiter : MonoBehaviour {

	public float limLeft = -4.7f;
	public float limRight = 4.587f;

	// Use this for initialization
	void Start () {
		limLeft = -4.7f;
		limRight = 4.587f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x > limLeft){
			transform.Translate(-.05f, 0, 0);
		}
	}
}

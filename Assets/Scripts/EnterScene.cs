using UnityEngine;
using System.Collections;

public class EnterScene : MonoBehaviour {

	public int counter = 0;
	public int end = 300;
	public bool triggered = false;

	// Use this for initialization
	void Start () {
		counter = 0;
		end = 300;
		triggered = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey (KeyCode.Return)) {
			triggered = true;
		}
		if(triggered){
			Screen.SetResolution(1280, 800, true);
			if(counter >= end){
				Application.LoadLevel(1);
			}
			counter++;
			transform.Translate(0, -.08f, 0);
		}	
	}
}

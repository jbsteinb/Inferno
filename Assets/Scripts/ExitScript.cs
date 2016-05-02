using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Cursor.visible = false;
		if(Input.GetKey(KeyCode.Return)){
			Application.Quit();
		}
	}
}

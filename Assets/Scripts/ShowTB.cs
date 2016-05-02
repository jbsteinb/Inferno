using UnityEngine;
using System.Collections;

public class ShowTB : MonoBehaviour {

	public int counter = 0;

	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.Space) && counter > 540){
			transform.Translate(0, 0, 100);
		}
		if(transform.position.z < 0)
			counter++;
	}
}

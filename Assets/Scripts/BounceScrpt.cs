using UnityEngine;
using System.Collections;

public class BounceScrpt : MonoBehaviour {

	public int counter = 0;
	public int num = 0;
	public int timer = 60;

	// Use this for initialization
	void Start () {
		counter = 0;
		num = 0;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(counter%timer == 0){
			num++;
		}
		if(counter%timer == 1 && num%2 == 0){
			transform.Translate(new Vector3(0, .5f, 0));
		}
		else if(counter%timer == 1 && num%2 == 1){
			transform.Translate(new Vector3(0, -.5f, 0));
		}
		counter++;
	}
}

using UnityEngine;
using System.Collections;

public class VirgilMoveScript : MonoBehaviour {

	public int counter = 0;
	public int num = 0;
	public int timer = 60;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		counter = 0;
		num = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(counter%timer == 0){
			num++;
		}
		if(num%2 == 0){
			transform.Translate(0, -0.005f, 0);
		}
		else if(num%2 == 1){
			transform.Translate(0, 0.005f, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -5){
			transform.Translate(-.05f, 0, 0);
		}
		counter++;
	}
}

using UnityEngine;
using System.Collections;

public class FadeIntoDankness : MonoBehaviour {

	public int counter = 0;
	public bool trigged = false;
	public bool trigged2 = false;
	
	// Use this for initialization
	void Start () {
		counter = 0;
		trigged = false;
		trigged2 = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Space) && counter >= 850 && trigged == false){
			transform.Translate(0, 0, -1.4f);
			counter = 0;
			trigged = true;
		}
		if(!trigged)
			counter++;
		else if(trigged)
			counter--;
		
		if(counter <= -500 && !trigged2){
			transform.Translate(0, -.1f, 0);
		}
		if(counter <= -800){
			Application.LoadLevel(2);
		}
	}
}

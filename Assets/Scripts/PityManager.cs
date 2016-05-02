using UnityEngine;
using System.Collections;

public class PityManager : MonoBehaviour {

	public int counter = 0;
	public Animator anim;
	public bool trigged = false;
	public bool trigged2 = false;
	
	// Use this for initialization
	void Start () {
		counter = 0;
		anim = this.GetComponent<Animator>();
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

		if(counter <= -400 && !trigged2){
			anim.Play("PityIntensifies");
			trigged2 = true;
		}
	}
}

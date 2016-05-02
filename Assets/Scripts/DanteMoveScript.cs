using UnityEngine;
using System.Collections;

public class DanteMoveScript : MonoBehaviour {

	public Animator anim;
	public int grabcount = 0;
	public bool snagged = false;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		anim = GetComponent<Animator>();
		grabcount = 0;
		snagged = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -7.3){
			transform.Translate(-.05f, 0, 0);
			anim.Play("WalkAnim");
		}
		if(Input.GetKey(KeyCode.Space) && grabcount >= 540 && snagged == false){
			anim.Play("ReachAnim");
			snagged = true;
		}

		if(grabcount >= 10 && grabcount <= 600)
			grabcount++;
	}

	void OnTriggerEnter2D (Collider2D target) {
		if(target.gameObject.tag == "VirgilTextBox"){
			target.transform.Translate(0, 0, -2);	
			//print ("It worked though");
		}
		if(target.gameObject.tag == "Space"){
			//target.transform.Translate(0, 0, -.2f);
			target.gameObject.GetComponent<SkipLineProperties>().triggered = true;
			//print ("It worked though");
			grabcount = 11;
		}
		if(target.gameObject.tag == "Tree"){
			target.gameObject.GetComponent<TreeAnimController>().counter = 1;
		}
	}
}

/*
 * 
 * public Animator anim;
 * anim = GetComponent<Animator>();
		anim.Play("Idle");
		anim.Play ("Climb");
		*/

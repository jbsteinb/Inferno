using UnityEngine;
using System.Collections;

public class TreeAnimController : MonoBehaviour {

	public Animator anim;
	public int counter = 0;
	public int secondCount = 0;
	public bool spaceTrig = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		counter = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Space) && counter >= 540){
			spaceTrig = true;

		}
		if(counter > 0)
			counter++;

		if(secondCount == 24)
			anim.Play("BranchFallAnim");

		if(spaceTrig)
			secondCount++;
	}
	
}

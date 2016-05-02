using UnityEngine;
using System.Collections;

public class ShowTreeText : MonoBehaviour {

	public int counter = 0;
	public AudioSource audioz;
	public bool trigged = false;

	// Use this for initialization
	void Start () {
		counter = 0;
		audioz = this.GetComponent<AudioSource>();
		trigged = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.Space) && counter >= 850 && transform.position.z >= -1.3f && trigged == false){
			transform.Translate(0, 0, -1.4f);
			audioz.Play();
			trigged = true;
		}
		counter++;
	}
}

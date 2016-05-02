using UnityEngine;
using System.Collections;

public class SkipLineProperties : MonoBehaviour
{

		public int counter = -450;
		public int num = 0;
		public int timer = 60;
		public bool triggered = false;
		public AudioSource swag;
	
		// Use this for initialization
		void Start ()
		{
				counter = -450;
				num = 0;
				triggered = false;
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				if (triggered) {
					if(counter == -400)
						swag.Play();
						
					if (counter % timer == 0 && counter >= 0) {
							num++;
					}
					
					if (counter % timer == 1 && num % 2 == 1  && counter > 0) {
							transform.Translate (new Vector3 (0, 0, -2f));
					} else if (counter % timer == 1 && num % 2 == 0) {
							transform.Translate (new Vector3 (0, 0, 2f));
					}
					counter++;
				}
				if (Input.GetKey(KeyCode.Space) && counter > 120){
					transform.Translate(0, 0, 100);
				}
		}
}

using UnityEngine;
using System.Collections;

public class lever : MonoBehaviour {

	public Animator door;
	public bool b;
	public AudioSource AS;
	public AudioClip AC;
	public bool brotate;
	public rotate scr;

	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (b == false) {
			if (other.tag == "Player") {
				GetComponent<Animator> ().SetBool ("b", true);
				AS.PlayOneShot (AC);
				door.SetBool ("b", true);
				b = true;

				if (brotate == true) {
					brotate = true;
					if (scr.r == false) {
						scr.r = true;
					} else {
						scr.r = false;
					}
			}
		}
	}
}
	public void back(){

		door.SetBool ("b", false);
		b = false;
		GetComponent<Animator> ().SetBool ("b",false);
	}
}



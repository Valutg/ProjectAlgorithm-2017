using UnityEngine;
using System.Collections;

public class btnDoor : MonoBehaviour {

	bool b;
	public Animator animator;
	public AudioSource AS;
	public AudioClip AC;
	public bool green;
	void OnTriggerStay (Collider other) {
		
		if (other.tag == "Player" || other.tag == "box" || other.tag == "enemy"||other.tag=="disable") {
			if (animator.GetBool ("b") == false) {
				if (green == false) {
					AS.PlayOneShot (AC);
				}
			}
			if (green) {
				animator.SetBool ("b", false);
			} else {
				animator.SetBool ("b", true);
			}
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player" || other.tag == "box" || other.tag == "enemy"||other.tag=="disable") {
			if (green) {
				animator.SetBool ("b", true);
			} else {
				animator.SetBool ("b", false);
			}
		}
	}
	void Start(){
		if (green) {
			animator.SetBool ("b", true);
		}
	}
}

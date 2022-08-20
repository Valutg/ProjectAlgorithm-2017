using UnityEngine;
using System.Collections;

public class scan : MonoBehaviour {

	public GameObject[] drs;
	public AudioSource AS;
	public AudioClip AC;


	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			drs = GameObject.FindGameObjectsWithTag ("enemy");
			for (int i = 0; i < drs.Length; i++) {
				drs [i].GetComponent<enemy> ().kill = true;
			}
			AS.PlayOneShot (AC);
		}
	}
}

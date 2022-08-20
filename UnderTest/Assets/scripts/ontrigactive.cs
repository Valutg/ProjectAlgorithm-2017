using UnityEngine;
using System.Collections;

public class ontrigactive : MonoBehaviour {

	public GameObject Enemy;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Enemy.GetComponent<enemy> ().kill = true;;
		}
	}
}

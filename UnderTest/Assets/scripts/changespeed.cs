using UnityEngine;
using System.Collections;

public class changespeed : MonoBehaviour {

	public float speed;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			other.GetComponent<UnityEngine.AI.NavMeshAgent> ().speed = speed;
		}
	}
}

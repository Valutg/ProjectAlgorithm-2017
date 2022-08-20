using UnityEngine;
using System.Collections;

public class bullvel : MonoBehaviour {

	public float speed;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		if (other.tag=="dcoll") {
			gameObject.GetComponent<Rigidbody> ().AddForce(other.transform.forward*speed);
			DestroyObject (other.gameObject);
		}
	}
}

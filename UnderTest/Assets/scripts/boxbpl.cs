using UnityEngine;
using System.Collections;

public class boxbpl : MonoBehaviour {

	public GameObject MessObj;

	void OnTriggerStay (Collider other) {
		if (other.tag == "Player" || other.tag == "box" || other.tag == "enemy") {
			MessObj.BroadcastMessage ("change");
		}
	}
}

using UnityEngine;
using System.Collections;

public class coll : MonoBehaviour {

	public bool sphere, box;

	public void truecoll () {
		if (sphere) {
			GetComponent<SphereCollider> ().enabled = true;
		}
		if (box) {
			GetComponent<BoxCollider> ().enabled = true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class btnmenudoor : MonoBehaviour {

	public Transform trm;
	public Transform[] points;
	public float speed;
	public bool[] lvlb;
	void Click () {

	}

	void Update () {
		if (trm.transform.position.x > transform.position.x) {
			transform.GetComponent<Rigidbody> ().AddForce (Vector3.right * speed);
		}
		if (trm.transform.position.x < transform.position.x) {
			transform.GetComponent<Rigidbody> ().AddForce (Vector3.left * speed);
		}
		}
	}


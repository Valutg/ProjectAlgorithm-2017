using UnityEngine;
using System.Collections;

public class way : MonoBehaviour {

	public bool b;
	public Transform t1,t2,t;
	public float speed;
	void Update () {
		if (b == false) {
			t = t1;
		} else {
			t = t2;
		}

			if (transform.position.x < t.transform.position.x) {
			transform.position += new Vector3 (1, 0, 0)*speed;
			}

			if (transform.position.x > t.transform.position.x) {
			transform.position += new Vector3 (-1, 0, 0)*speed;
			}

		if (transform.position.z < t.transform.position.z) {
			transform.position += new Vector3 (0, 0, 1)*speed;
		}

		if (transform.position.z > t.transform.position.z) {
			transform.position += new Vector3 (0, 0, -1)*speed;
		}
		if (transform.position.x > t.transform.position.x - 0.1&&transform.position.x < t.transform.position.x + 0.1
			&&transform.position.z>t.transform.position.z-0.1&&transform.position.z<t.transform.position.z+0.1) {
			change ();
		}

	}
	void change(){
		if (b == false) {
			b = true;
		} else {
			b = false;
		}
	}


}

using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {


	public float speed;
	public bool r;

	void Update () {
		if (r == false) {
			transform.Rotate (-transform.up * Time.deltaTime * speed * 40);
		} else {
			transform.Rotate (transform.up * Time.deltaTime * speed * 40);
		}
	}
}

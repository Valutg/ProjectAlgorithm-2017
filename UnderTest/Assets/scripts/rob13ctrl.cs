using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rob13ctrl : MonoBehaviour {

	public bool right,left,up,down;
	Rigidbody rb;
	public float speed;

	void Start() {
        
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	void Update () {
		if (right) {  rb.velocity += new Vector3(speed*Time.deltaTime, 0, 0);  }
        if (left) { rb.velocity += new Vector3(-speed * Time.deltaTime, 0, 0); }
        if (up) { rb.velocity += new Vector3(0, 0, speed * Time.deltaTime); }
        if (down) { rb.velocity += new Vector3(0, 0, -speed * Time.deltaTime ); }   
    }
}

using UnityEngine;
using System.Collections;

public class cameramove : MonoBehaviour {

	Rigidbody rb;

	public bool left,right;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}

	public void LeftOn () {
		left = true;
	}
	public void LeftOff () {
		left = false;
	}
	public void RightOn(){
		right = true;
	}
	public void RightOff(){
		right = false;
	}
    void Update() {
        if (left) {
            if (transform.position.x > -55.86) {
                transform.position += new Vector3(-0.09f, 0, 0) * 2;
            }
        }
        if (right) {
            if (transform.position.x < 1111.78) { 
            transform.position += new Vector3(0.09f, 0, 0) * 2;
        }
    }
	}
}

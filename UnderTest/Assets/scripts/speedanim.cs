using UnityEngine;
using System.Collections;

public class speedanim : MonoBehaviour {

	public float speed;

	void Start () {
		GetComponent<Animator> ().speed = speed;
	}
	

}

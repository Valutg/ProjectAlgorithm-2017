using UnityEngine;
using System.Collections;

public class lookat : MonoBehaviour {

	Transform player;

	void Start(){
		player = GameObject.FindWithTag ("Player").transform;
	}

	void Update () {
		transform.LookAt (player);
	}
}

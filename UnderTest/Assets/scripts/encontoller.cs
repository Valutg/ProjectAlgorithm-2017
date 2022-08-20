using UnityEngine;
using System.Collections;

public class encontoller : MonoBehaviour {


	public UnityEngine.AI.NavMeshAgent nav;
	public bool start;
	public int index;
	public GameObject[] Steps;
	public float speedp;


	// Update is called once per frame

	void Start(){
		Steps = GameObject.FindGameObjectsWithTag ("stepen");

	}

	void Update () {
		if (start) {
			for (int i = 0; i < Steps.Length; i++) {
				if (Steps [i].GetComponent<index> ().indexstep == index) {
					nav.destination = Steps [i].transform.position;
				}
			}
		}
	}
	void OnTriggerStay(Collider other){

		if (other.tag == "stepen") {
			if (other.GetComponent<index> ().indexstep == index) {
				index += 1;
				other.gameObject.SetActive (false);
			}
		}
	
	}
	public void startm(){

		start = true;
		nav.enabled = true;
	}
}

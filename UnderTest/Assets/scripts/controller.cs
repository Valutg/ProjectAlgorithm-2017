using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class controller : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent nav;
	public bool start;
	public int index;
	public GameObject[] Steps;
	public Slider slr;
	public stepscreating scrStepC;
	public GameObject WindowGO;
	public AudioSource AS;
	public AudioClip AC;

	public AudioClip AC2;
	public Animator animatorCam;
	bool d;
	public float speedp;
	public AudioSource ASS;
	public Color clr;
	// Update is called once per frame

	void Update () {
		clr = Color.gray;
		if (start) {
			ASS.pitch = slr.value/2;
			Steps = GameObject.FindGameObjectsWithTag ("step");
			for (int i = 0; i < Steps.Length; i++) {
				if (Steps [i].GetComponent<index> ().indexstep == index) {
					nav.destination = Steps [i].transform.position;
				}
			}
			nav.speed = slr.value;
		}
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "jcoll") {
			GetComponent<Rigidbody> ().AddForce (other.transform.up * speedp);
		}
		if (other.tag == "step") {
			if (other.GetComponent<index> ().indexstep == index) {
				index += 1;
				other.gameObject.SetActive (false);
			}
		}
		if (d==false){
			if (nav.enabled==true){
				if (other.tag == "dcoll"||other.tag=="disable") {
				WindowGO.SetActive (true);
				GetComponent<UnityEngine.AI.NavMeshAgent> ().enabled = false;
				GetComponent<controller> ().enabled = false;
				GetComponent<Rigidbody> ().isKinematic = false;

					gameObject.transform.GetChild(0).GetComponent<MeshRenderer> ().materials [1].color = clr;
					gameObject.transform.GetChild (0).GetComponent<MeshRenderer> ().materials [1].SetColor("_EmissionColor",clr);
					gameObject.transform.GetChild(1).GetComponent<MeshRenderer> ().materials [0].color = clr;
					gameObject.transform.GetChild (1).GetComponent<MeshRenderer> ().materials [0].SetColor("_EmissionColor",clr);
				 
					gameObject.transform.GetChild (2).GetComponent<Light> ().enabled = false;		
				ASS.enabled = false;
				AS.PlayOneShot (AC);
				GetComponent<Rigidbody> ().useGravity = true;

				animatorCam.SetBool ("d",true);
				d = true;
			}
		}
	}
	}
	public void startm(){
		ASS.enabled = true;
		start = true;
		GameObject.FindWithTag ("Audio").GetComponent<AudioSource>().PlayOneShot(AC2);
		nav.enabled = true;
		GameObject[] collobjs = GameObject.FindGameObjectsWithTag ("coll");
		for (int ii = 0; ii < collobjs.Length; ii++) {
			collobjs [ii].BroadcastMessage ("truecoll");
		}
		scrStepC.enabled = false;
	}

}

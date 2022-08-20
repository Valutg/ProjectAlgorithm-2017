using UnityEngine;
using System.Collections;

public class disablectr : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent nav;
	public GameObject[] lvr;
	public GameObject lvrp;
	int i;
	public bool b;
    public AudioSource AS;
    public AudioClip AC;
    public Vector3 strm;
	void Start () {
        strm=gameObject.transform.position;
		lvr = GameObject.FindGameObjectsWithTag("lever");
		for (i = 0; i < lvr.Length; i++) {
			lvr[i] = lvr [i].transform.parent.gameObject;	
		}
	}
	

	void Update () {
		if (b == false) {
			for (i = 0; i < lvr.Length; i++) {
				if (lvr [i].GetComponent<lever> ().b== true) {					
					lvrp = lvr [i];
                   
					b = true;	
				}
			}
		}
		if (b) {
			nav.enabled = true;
			nav.destination = lvrp.transform.position;
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.name=="lever") {
			b = false;
			if (b == true) {
				AS.PlayOneShot (AC);
			}
            nav.destination=strm ;
			lvrp.GetComponent<lever> ().back ();
		}
	}
}

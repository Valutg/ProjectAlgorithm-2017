using UnityEngine;
using System.Collections;

public class stepscreating : MonoBehaviour {

	public Camera cam;
	public Transform trm;
	RaycastHit hit;
	public int indexstep;
	public index scrindex;
	Ray ray;
	public AudioSource AS;
	public AudioClip AC;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			ray=cam.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 10000)) {
				if (hit.transform.tag == "floor") {
					Transform step = Instantiate (trm, new Vector3 (hit.point.x, hit.point.y+0.09f, hit.point.z), Quaternion.identity) as Transform;
					step.GetComponent<index> ().indexstep = indexstep;
					indexstep += 1;
					AS.PlayOneShot (AC);
				}
			}
		}
	}
	}
	


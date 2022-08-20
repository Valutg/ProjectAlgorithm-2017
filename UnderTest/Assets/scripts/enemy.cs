using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {


	public UnityEngine.AI.NavMeshAgent nav;
	public GameObject Player;
	public float dist;
	public bool kill;
	public MeshRenderer[] MatObj;
	public int[] indexMat;
	public Material mat;
	public AudioSource AS;
	public AudioClip AC;
	void Start () {
		Player = GameObject.FindWithTag ("Player");
	}
	
	void Update () {
		if (kill == false) {
			if (Vector3.Distance (Player.transform.position, transform.position) < dist) {
				kill = true;
				AS.PlayOneShot (AC);
				for (int i = 0; i < MatObj.Length; i++) {
					MatObj [i].materials[indexMat[i]].color = Color.red;
					MatObj [i].materials [indexMat [i]].SetColor ("_EmissionColor", Color.red);

				}
			
			}
		}
		if (kill) {
			nav.destination = Player.transform.position;
		}
		if (Player.GetComponent<controller> ().enabled == false) {
			GetComponent<enemy> ().enabled = false;
			GetComponent<UnityEngine.AI.NavMeshAgent> ().enabled = false;
			GetComponent<Rigidbody> ().isKinematic = false;

		}
	}
}

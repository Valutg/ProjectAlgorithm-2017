using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {

	float count;

	public float ogr,speed,r1,r2;
	public Transform bullet;
	public Transform trmp;
	public bool b;
	public AudioSource AS;
	public AudioClip AC;

	void Start(){
		if (b) {
			ogr = Random.Range (r1, r2);
		}
	}
		

	// Update is called once per frame
	void Update () {
		count += 1 * Time.deltaTime;

		if (count > ogr) {
			Transform bulletClone;
			AS.pitch = Random.Range (0.9f, 1.4f);
			bulletClone = Instantiate (bullet, trmp.position, trmp.rotation) as Transform;
			bulletClone.GetComponent<Rigidbody>().AddForce (trmp.forward*speed);
			count = 0;
			AS.PlayOneShot (AC);
			if (b) {
				ogr = Random.Range (r1, r2);
			}
		}
	}
}

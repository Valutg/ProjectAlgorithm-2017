using UnityEngine;
using System.Collections;

public class animationkletka : MonoBehaviour {

	public GameObject Kletka;
	public float speed,zl;
	public bool l,r,stop,rotatel,rotater;
	public animationkletka scr;
	public void Click () {
		if (l) {
			rotatel = true;
			scr.rotater = false;
		}
		if (r) {
			rotater=true;
			scr.rotatel = false;
		}
		if (stop) {
			scr.rotatel = false;
			scr.rotater = false;
		}
	}
	void Update(){
		zl = Kletka.transform.rotation.z;
		if (rotatel) {
			if (0.3 >zl) {
				Kletka.transform.Rotate (-Vector3.back * speed * Time.deltaTime);
			} 
		}
		if (rotater) {
			if (-0.2<zl) {
					Kletka.transform.Rotate (Vector3.back * speed*Time.deltaTime);
		}
	}
}
}

using UnityEngine;
using System.Collections;

public class falsedestroy : MonoBehaviour {


	public bool falseb;
	public float count,ogr;
	void Update () {
		count += Time.deltaTime;
		if (count > ogr) {
			if (falseb) {
				gameObject.SetActive (false);
			} else {
				Destroy (gameObject);
			}
		}
	}
}

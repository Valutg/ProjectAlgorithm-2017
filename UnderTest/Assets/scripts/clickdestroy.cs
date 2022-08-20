using UnityEngine;
using System.Collections;

public class clickdestroy : MonoBehaviour {

	public GameObject trueobj;

	public void OnMouseDown () {
		Click ();	
	}
	public void Click(){
		trueobj.SetActive (true);
		Destroy (gameObject, 0.01f);
	}

}

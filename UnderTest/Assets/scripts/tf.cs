using UnityEngine;
using System.Collections;

public class tf : MonoBehaviour {

	public GameObject TrueObj;
	public GameObject FalseObj;

	public void Click () {
		TrueObj.SetActive (true);
		FalseObj.SetActive (false);
	}

}

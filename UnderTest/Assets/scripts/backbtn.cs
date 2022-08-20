using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbtn : MonoBehaviour {

    public GameObject slr,CameraDoor,Camera;


	public void Click () {
        Camera.SetActive(true);
        CameraDoor.SetActive(false);
        slr.SetActive(true);
	}
}

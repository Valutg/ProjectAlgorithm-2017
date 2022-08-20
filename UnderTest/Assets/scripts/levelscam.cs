using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelscam : MonoBehaviour {

    public Text text;
    public int i;
    public Transform[] trm;
    public Transform Cam;

    public void Start()
    {
    }

    public void Drag () {
        text.text=GetComponent<Slider>().value.ToString();
        i = Mathf.RoundToInt(GetComponent<Slider>().value);
        Cam.position =trm[Mathf.RoundToInt(GetComponent<Slider>().value)].position;
	}
}

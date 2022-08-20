using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class outputsumm : MonoBehaviour {

    float summf;
    public Text text1,text2,text3;
    public float sot,ed,des;
   
	void Start () {
        summf=PlayerPrefs.GetFloat("summrooms");
        if (summf > 999)
        {
            summf = 999;
        }
        sot = Mathf.Floor(summf/100);
        ed = Mathf.Floor(summf%10);
        des = Mathf.Abs(Mathf.Floor(((summf - sot * 100) - ed) / 10));
       
        text1.text = sot.ToString();
        text2.text = des.ToString();
        text3.text = ed.ToString();
    }
	
	
}

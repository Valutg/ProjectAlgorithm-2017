using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class texttimer : MonoBehaviour {

    timer timerscr;
    Text text;
    float count;
	void Start () {
        timerscr = GameObject.FindWithTag("timer").GetComponent<timer>();
        text = GetComponent<Text>();
    }
	
	void Update () {
        count = Mathf.Round(timerscr.count);
        text.text = count.ToString();
	}
}

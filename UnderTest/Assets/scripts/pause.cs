using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public GameObject pauseobj;
	public GameObject winL, winW,whiteWin;
	public GameObject inf,inf2;
	public stepscreating scr;
	public AudioSource AS;
	public AudioClip AC;

	void Start(){
		whiteWin = GameObject.Find ("PanelWhite");
		AS=GameObject.FindWithTag ("Audio").GetComponent<AudioSource>();
		GameObject.FindWithTag ("timer").BroadcastMessage("mess",Application.loadedLevel);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (winL.active == false && winW.active == false) {
				whiteWin.SetActive (false);
				if (pauseobj.active == true) {
					Time.timeScale = 1;
					pauseobj.SetActive (false);
					inf.SetActive (true);
					inf2.SetActive (true);
					scr.enabled = true;
				} else {
					Time.timeScale = 0;
					pauseobj.SetActive (true);
					inf.SetActive (false);
					inf2.SetActive (false);
					scr.enabled = false;
				}
			}
		}
	}
	public void Continue(){
		Time.timeScale = 1;
		AS.PlayOneShot (AC);
		pauseobj.SetActive (false);
		inf.SetActive (true);
		inf2.SetActive (true);
		scr.enabled = true;
	}
}

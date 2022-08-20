using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class menu : MonoBehaviour {

	public bool exit,ono,offo,ll,nll,tryb,nl,notuslvl=false;
	public int levelint;
	public GameObject trueObj,falseObj; 
	public float levels;
	public AudioClip AC;
	public AudioSource AudioS;


	public void Start(){
		AudioS = GameObject.FindWithTag ("Audio").GetComponent<AudioSource>();
	//	levels = PlayerPrefs.GetFloat (gameObject.name);
	//	PlayerPrefs.SetFloat (gameObject.name,);
		if (notuslvl) {
			PlayerPrefs.SetFloat ("lvl0", 1);
			levels = PlayerPrefs.GetFloat (gameObject.name);
			if (levels == 1) {
				GetComponent<Image> ().color = Color.white;
				GetComponent<Button> ().enabled = true;
			} else {
				GetComponent<Image> ().color = Color.gray;
				GetComponent<Button> ().enabled = false;
			}
		}
	}

	public void OnClick() {
		AudioS.PlayOneShot (AC);
		if (exit) {
			Application.Quit ();
		}
		if (ll) {
			if (notuslvl) {
				if (levels == 1) {
					Application.LoadLevel (levelint);
		
				} 
			}else {
				Application.LoadLevel (levelint);
			}
		}
		if (nll) {
			Application.LoadLevel (Application.loadedLevel + 1);
		}
		if (tryb) {
			Application.LoadLevel (Application.loadedLevel);
		}
		if (ono) {
			falseObj.SetActive (false);
			trueObj.SetActive (true);
		}
		if (nl) {
			Application.LoadLevel (Application.loadedLevel);
		}
		if (offo) {
			trueObj.SetActive (false);
			falseObj.SetActive (true);
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volumechange : MonoBehaviour {
	Slider slr;
	float savemusic=1.0f;
	public AudioSource Audio;
	void Start () {
		Audio = GameObject.FindWithTag ("timer").GetComponent<AudioSource>();
		savemusic = PlayerPrefs.GetFloat ("sm");
		Audio.volume = savemusic;
		slr = gameObject.GetComponent<Slider> ();
		slr.value = savemusic;
	}
	

	public void ChangeVolume() {
		Audio.volume = slr.value;
		PlayerPrefs.SetFloat ("sm",Audio.volume);
	}
}

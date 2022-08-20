using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	public int levelm;
	public float count;
	public AudioSource audio;
	public AudioClip[] ACs;
	public bool play;



	void Start () {
		
		if (PlayerPrefs.HasKey ("sm")) {

		} else {
			audio.volume = 1.0f;
			PlayerPrefs.SetFloat ("sm", audio.volume);
		}
		if (PlayerPrefs.HasKey ("sm")) {

		} else {
			audio.volume = 1.0f;
			PlayerPrefs.SetFloat ("sm", audio.volume);
		}
		DontDestroyOnLoad (gameObject);
		Application.LoadLevel (Application.loadedLevel + 1);
		audio.volume=PlayerPrefs.GetFloat ("sm");
	}
	
	// Update is called once per frame
	void Update () {
		if (!play) {
			audio.clip = ACs[Random.Range (0, ACs.Length)];
			play = true;
			audio.Play ();
			StartCoroutine (Delay ());

		}
		if (Application.loadedLevel == levelm) {
			count += Time.deltaTime;
		} else {
			count = 0;
		}
	}

	private IEnumerator Delay () {
		yield return new WaitForSeconds (audio.clip.length*Time.timeScale);
		play = false;
	}

	public void mess(int level){
		levelm = level;
	}

}

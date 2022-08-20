using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textanim : MonoBehaviour {

	public float count,ogr;
	public Text text;
	public string str;
	int i;
	public AudioSource AS;
	public AudioClip AC;

	void Update () {
		if (i < str.Length) {
			count += Time.deltaTime;
			if (count > ogr) {
				count = 0;
				text.text += str.Substring (i, 1);
				i += 1;
				ogr = Random.Range (0.1f,0.2f);
				AS.pitch=(Random.Range(2f,2.3f));
				AS.PlayOneShot (AC);
			}
		}
	}
}

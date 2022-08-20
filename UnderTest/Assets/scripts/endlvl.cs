using UnityEngine;
using System.Collections;

public class endlvl : MonoBehaviour {

	public GameObject panel;
	public float count;
	void Update () {
		count += 1 * Time.deltaTime;
		if (count > 11) {
			panel.SetActive (true);
		}
		if (count > 28) {
			Application.LoadLevel ("menu");
		}
	}
}

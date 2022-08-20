using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class changetextonmouse : MonoBehaviour {

	public Text text,text2;
	public string texts,texts2;
	public Color clrsave;
	public GameObject panel;
	void OnMouseEnter() {
		clrsave = GetComponent<MeshRenderer> ().material.color;
		GetComponent<MeshRenderer> ().material.color = Color.gray;
		text.text = texts;
	}
	void OnMouseUp(){
		panel.SetActive (true);
		text2.text = texts2;
	}
	public void Click(){
		panel.SetActive (false);
	}

	void OnMouseExit() {
		GetComponent<MeshRenderer> ().material.color = clrsave;
		text.text = "Ничего не вижу";
	}
}

using UnityEngine;
using System.Collections;

public class finishgame : MonoBehaviour {


	public GameObject winwindow; 
	public controller scrController;
	public Animator animator;
	public GameObject Int1,Int2;
	public UnityEngine.AI.NavMeshAgent nav;
    
	void OnTriggerEnter (Collider other) {

			if ((other.tag == "Player" && other.transform.GetComponent<controller> ().enabled == true)||(other.tag=="robo")) {
            PlayerPrefs.SetFloat(Application.loadedLevelName, 1);
			PlayerPrefs.Save();
			scrController.ASS.GetComponent<AudioSource> ().enabled = false;
			scrController.ASS.enabled = false;	
			scrController.AS.enabled = false;	
			    winwindow.SetActive (true);
				animator.SetBool ("b", true);
				Int1.SetActive (false);
				Int2.SetActive (false);
				nav.enabled = false;
				scrController.ASS.enabled = false;
				scrController.enabled = false;
			}

}

}

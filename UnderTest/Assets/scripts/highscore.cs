using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class highscore : MonoBehaviour {

	public float count,hs,summf;
	public Text texths,textcount;
    

	void Start () {
        GameObject.Find("DGNB").SetActive(false);
        count = GameObject.FindWithTag ("timer").GetComponent<timer> ().count;
		hs=PlayerPrefs.GetFloat ("highscore"+ Application.loadedLevelName);
		if (PlayerPrefs.GetFloat ("highscore"+ Application.loadedLevelName)==0) {
			PlayerPrefs.SetFloat ("highscore" + Application.loadedLevelName, 100000);
			texths.text = "NEW HIGHSCORE ! ";
		} else {
			texths.text = "Highscore : " + hs.ToString () + " sec.";
		}
		hs = PlayerPrefs.GetFloat ("highscore"+ Application.loadedLevelName);

		count = Mathf.Round(count);

		textcount.text = "YOU PASSED A ROOM IN "+count.ToString()+" sec.";
		if (hs > count) {
            summf = PlayerPrefs.GetFloat("summrooms");
            summf -= hs;
            hs = count;
            summf += hs;
            PlayerPrefs.SetFloat("summrooms", summf);
            PlayerPrefs.SetFloat ("highscore"+Application.loadedLevelName,count);
         
            
		}

	
	}

}

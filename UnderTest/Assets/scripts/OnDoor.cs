using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDoor : MonoBehaviour {

    
    public bool Menu, LL, Exit;
    public int Level;
    public float levels;
    public GameObject red, green,CameraDoor,Camera,slr;
	public AudioSource AudioS;
	public AudioClip AC;
     void Start()
    {
        PlayerPrefs.SetFloat("lvl0",1);
		AudioS = GameObject.FindWithTag ("Audio").GetComponent<AudioSource>();
        levels = PlayerPrefs.GetFloat(gameObject.name);
       
    }

    public void Click()
    {
        if (LL)
        {
            if (levels == 1)
            {
                Application.LoadLevel(Level);
            }
        }
        if (Exit)
        {
            Application.Quit();
        }
      
    }


   


}

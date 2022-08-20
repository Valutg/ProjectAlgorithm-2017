using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class finishcheck : MonoBehaviour {


    bool b;
    public Image img1, img2, img3;
    public Text text1, text2, text3;
    public Sprite imgs1, imgs2;
    float count;
    public float countogr;
    public Animator animdoor1, animdoor2;
    public way Wayscr;
    public GameObject Player;
	public AudioSource AS;
	public AudioClip AC;
	public bool b1,b2,b3;
	 void OnTriggerEnter (Collider other) {
        if (other.tag == "Player")
        {
            Player.GetComponent<controller>().enabled = false;
			Player.GetComponent<NavMeshAgent>().enabled = false;
			Player.GetComponent<controller> ().ASS.enabled = false;
            b = true;
            GetComponent<BoxCollider>().enabled = false;
        }
	}
    void Update()
    {
        if (b)
        {
            count += 1 * Time.deltaTime;
            if (count > 1)
            {
                text1.color = Color.green;
                img1.sprite = imgs1;
				if (b1 == false) {
					b1 = true;
					AS.PlayOneShot (AC);
				}
            }
            if (count > 2)
            {
                text2.color = Color.green;
				img2.sprite = imgs1;
				if (b2 == false) {
					b2 = true;
					AS.PlayOneShot (AC);
				}
            }
            if (count > countogr)
			{
				if (b3 == false) {
					b3 = true;
					AS.PlayOneShot (AC);
					Player.GetComponent<controller> ().enabled = true;
					Player.GetComponent<NavMeshAgent> ().enabled = true;
					Player.GetComponent<controller> ().ASS.enabled = true;
					text3.color = Color.green;
					img3.sprite = imgs1;
					animdoor1.SetBool ("b", true);
             
				}
             
            }
        }

    }
}

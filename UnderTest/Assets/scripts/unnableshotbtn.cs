using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unnableshotbtn : MonoBehaviour
{

    public shot scr;

    void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player" || other.tag == "Box" )
        {
            scr.enabled = true;
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Box")
        {
            scr.enabled = false;
        }
    }
}
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerobo : MonoBehaviour {

    public rob13ctrl scr;
    public bool right, left, up, down;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player"|| other.tag == "box")
        {
            if (right) { scr.right = true; Debug.Log("Entered"); }
            if (left) { scr.left = true; }
            if (up) { scr.up = true; }
            if (down) { scr.down = true; }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player"||other.tag == "box")
        {
            if (right) { scr.right = false; Debug.Log("Exit"); }
            if (left) { scr.left = false; }
            if (up) { scr.up = false; }
            if (down) { scr.down = false; }
        }
    }
}

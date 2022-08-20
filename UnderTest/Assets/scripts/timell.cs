using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timell : MonoBehaviour {

    float count;
	void Update () {
        count += 1 * Time.deltaTime;
        if (count > 22)
        {
            Application.LoadLevel(1);
        }
	}
}

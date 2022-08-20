using UnityEngine;
using System.Collections;

public class destroybull : MonoBehaviour
{
    float count;
    public float ogr;



    void Update()
    {
        count += 1 * Time.deltaTime;
        if (count > ogr)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Untagged" || other.tag == "Player" || other.tag == "dcoll") ;
        {
            {
                Destroy(gameObject);
            }
            if (other.gameObject.tag == "box")
            {
                Destroy(gameObject, 0.02f);
            }
        }
    }
}

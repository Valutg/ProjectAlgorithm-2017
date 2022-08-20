using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnit : MonoBehaviour
{
    public Transform trmp;
    public float dist,speed;
    public Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        trmp = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector3.Distance(trmp.position, transform.position) < dist)
        {
            if (transform.position.x < trmp.position.x)
            {
				rb.velocity +=new Vector3(-speed*Time.deltaTime,0,0);
            }
			if (transform.position.x > trmp.position.x)
			{
				rb.velocity +=new Vector3(speed*Time.deltaTime,0,0);
			}
			if (transform.position.y > trmp.position.y)
			{
				rb.velocity +=new Vector3(0,0,speed*Time.deltaTime);
			}
			if (transform.position.y < trmp.position.y)
			{
				rb.velocity +=new Vector3(0,0,-speed*Time.deltaTime);
			}
        }

    }
}
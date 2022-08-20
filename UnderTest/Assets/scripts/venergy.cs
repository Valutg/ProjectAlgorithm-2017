using UnityEngine;
using System.Collections;

public class venergy : MonoBehaviour {


	public float speed,count,ogr,ix,iy;


	void Update () {
		count += 1 * Time.deltaTime;
		if (count > ogr) {
			ogr = Random.Range (0.3f, 0.6f);
			count = 0;
			ix=Random.Range (-2, 2);
			iy = Random.Range (-2, 2);
		}

		transform.position += new Vector3 (ix/100, 0, iy/100)*speed;
	}
}

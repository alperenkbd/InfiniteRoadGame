using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetoNext : MonoBehaviour {

    public bool isittouch;
    float Ypos;

	void Start () {
        isittouch = false;
        Ypos = Random.Range(3.93f, 6.87f);
        transform.position = new Vector3(Ypos, transform.position.y, transform.position.z);
		
	}
	
	
	void Update () {

        if (isittouch)
        {

            Invoke("iterator", 2.4f);

            

            isittouch = false;

        }




		
	}



    void iterator()
    {

        Ypos = Random.Range(3.93f, 6.87f);

        transform.position =transform.position + new Vector3(0, 12.5f, 0);

        transform.position = new Vector3(Ypos, transform.position.y, transform.position.z);

    }





}

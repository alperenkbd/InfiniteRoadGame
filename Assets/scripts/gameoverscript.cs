using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameoverscript : MonoBehaviour {

    
    public void retrybutton()
    {
        Application.LoadLevel("CyberTruck");

        Time.timeScale = 1;
    }



}

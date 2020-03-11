using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControl : MonoBehaviour {

    public GameObject getReadyPanel;
    public GameObject MainPanel;
    public GameObject MuniCharacter;



    public void PlayButton()
    {

        getReadyPanel.SetActive(true);
        MainPanel.SetActive(false);
        MuniCharacter.SetActive(true);

    }


}

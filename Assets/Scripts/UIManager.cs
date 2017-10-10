using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject AmmoPanel;
    private bool onScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonPressed()
    {
        Debug.Log("Button Pressed");

        if (!onScreen)
        {
            AmmoPanel.SetActive(true);
            onScreen = true;
        }
        else
        {
            AmmoPanel.SetActive(false);
            onScreen = false;
        }


    }


    public void ChangeAmmo(string ammoSlot)
    {
        Debug.Log("You chose : " + ammoSlot);
        Debug.Log(AmmoLookup.GetCorrectAmmo("Crossbow", ammoSlot));
    }
}

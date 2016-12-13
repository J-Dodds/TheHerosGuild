using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    int currentGold = 0;

    public Text goldText;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       goldText.text = "Gold: " + currentGold;
    }

    public void GoOnQuest()
    {
        currentGold += 10;
    }
}

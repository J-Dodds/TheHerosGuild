using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAdventuerer : MonoBehaviour
{
    public GameObject adventuererObject;
    public GameObject adventuererSpawnPoint;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void InstantiateAdventuerer()
    {
        Instantiate(adventuererObject, adventuererSpawnPoint.transform);
    }
}

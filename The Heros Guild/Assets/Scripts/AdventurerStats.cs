using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerStats : MonoBehaviour
{
    //public GameDirector gameDirector;

    //Types of classes
    private enum AdventuererClass
    {
        eACRanger,
        eACRouge,
        eACPaladin,
        eACWarrior,
        eACWizard,

        eACNumOfClasses
    }

    float currentClassFloat;
    AdventuererClass adventuererClass;
    string classText;
    //Material classMaterial;

    //Potential materials
    public Material rangerMaterial;
    public Material rougeMaterial;
    public Material paladinMaterial;
    public Material warriorMaterial;
    public Material wizardMaterial;

    //Character stats
    //Health
    int constitutionStat = 1;
        //Strength attack damage and ability to push stuff
    int strengthStat = 1;
        //Dexterity attack damage and ability to climb and jump
    int dexterityStat = 1;
        //Spell attack damage and ability to discern information
    int intelligenceStat = 1;
        //Chance to find extra loot
    int luckStat = 1;

    //Character health
    int maxHealth = 10;
    private int currentHealth = 0;
    int healthPerLevel = 10;

    //Character level
    int currentLevel = 1;
    int maxLevel = 100;
    float currentExperience = 0;

	//On object initialization
	void Awake ()
    {
        //Randomly decide class
        currentClassFloat = (int)Random.Range(0, (float)AdventuererClass.eACNumOfClasses);

        //Set Class
        if(currentClassFloat == (float)AdventuererClass.eACRanger)
        {
            adventuererClass = AdventuererClass.eACRanger;
            gameObject.GetComponent<MeshRenderer>().material = rangerMaterial; 
            classText = "Ranger";
            constitutionStat = 2;
            strengthStat = 1;
            dexterityStat = 5;
            intelligenceStat = 3;
            luckStat = 4;
        }
        else if (currentClassFloat == (float)AdventuererClass.eACRouge)
        {
            adventuererClass = AdventuererClass.eACRouge;
            gameObject.GetComponent<MeshRenderer>().material = rougeMaterial;
            classText = "Rouge";
            constitutionStat = 3;
            strengthStat = 3;
            dexterityStat = 5;
            intelligenceStat = 1;
            luckStat = 4;
        }
        else if (currentClassFloat == (float)AdventuererClass.eACPaladin)
        {
            adventuererClass = AdventuererClass.eACPaladin;
            gameObject.GetComponent<MeshRenderer>().material = paladinMaterial;
            classText = "Paladin";
            constitutionStat = 5;
            strengthStat = 4;
            dexterityStat = 1;
            intelligenceStat = 2;
            luckStat = 3;
        }
        else if (currentClassFloat == (float)AdventuererClass.eACWarrior)
        {
            adventuererClass = AdventuererClass.eACWarrior;
            gameObject.GetComponent<MeshRenderer>().material = warriorMaterial;
            classText = "Warrior";
            constitutionStat = 4;
            strengthStat = 5;
            dexterityStat = 2;
            intelligenceStat = 1;
            luckStat = 3;
        }
        else if (currentClassFloat == (float)AdventuererClass.eACWizard)
        {
            adventuererClass = AdventuererClass.eACWizard;
            gameObject.GetComponent<MeshRenderer>().material = wizardMaterial;
            classText = "Wizard";
            constitutionStat = 1;
            strengthStat = 2;
            dexterityStat = 3;
            intelligenceStat = 5;
            luckStat = 4;
        }
        else
        {
            Debug.Log("Something has gone wrong will setting the class");
        }

        //Set maxHealth and health
        maxHealth = (healthPerLevel * currentLevel) * constitutionStat;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}

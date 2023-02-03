using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//[attribute of the class] together with inheritance from Scriptable object allows to create instances of class
//in project menu: Assets /ScriptableObjects /Create Game Settings
[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/Create Game Settings", order = 1)]

public class GameSettingsDatabase : ScriptableObject
{

    public float playerHealth;
    public float enamyHealth;

    public float gunDamage;
    public float gunRange;


    void Start()
    {
        playerHealth = 100;
        enamyHealth = 100;
        gunDamage = 1f;
        gunRange = 50f;
    }



}

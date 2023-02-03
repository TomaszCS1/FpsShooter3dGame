using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//[attribute of the class] together with inheritance from Scriptable object allows to create instances of class
//in project menu: Assets /ScriptableObjects /Create Game Settings
[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/Create Game Settings", order = 1)]

public class GameSettingsDatabase : ScriptableObject
{

    public int m_health = 0;

    public int healthO
    {
        get { return m_health; }
        set
        {
            m_health = value;

        }
    }

    public int m_points = 0;

    public int points
    {
        get { return m_points; }
        set
        {
            m_points = value;

        }
    }

    public float health;
    

    public float gunDamage = 1f;
    public float gunRange;


    void Start()
    {
        ;
    }



}

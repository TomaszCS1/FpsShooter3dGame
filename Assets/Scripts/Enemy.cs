using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameSettingsDatabase gameSettingsDatabase;
    public GameObject healthBarUI;
    public Slider slider;
    private float health;

    // Start is called before the first frame update
    void Start()
    {
        gameSettingsDatabase.enemyHealth = 100;

        health = gameSettingsDatabase.enemyHealth;
        slider.value = 1;
        healthBarUI.SetActive(false);

        //Debug.Log("gameSettingsDatabase.enemyHealth: " + gameSettingsDatabase.enemyHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (health < 100)
        {
            healthBarUI.SetActive(true);
        }

     
      if (health <= 0) 
        {
            Destroy(gameObject);
            health = 100;
        }

   
    }


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("bullet"))
        {
            health -= 20;
            gameSettingsDatabase.enemyHealth = health;
            slider.value = (health)/100;

        }

        
    }

    

}

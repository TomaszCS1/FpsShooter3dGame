using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameSettingsDatabase gameSettingsDatabase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("bullet"))
        {
            gameSettingsDatabase.enamyHealth -= 2;

        }


    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameSettingsDatabase GameSettingsDatabase;
    public float damage;
    public float range;

    public Camera cam;
    public GameObject bulletSpawnPoint;
    public Vector3 hitPosition;

    public GameObject shotHolePrefab;
    
    public float spreadFactor= 0.02f;
    public float spreadCrouching = 0.02f;
    public float spreadNormal = 0.04f;



    public Vector3 shootingDirection;
    public Vector3 shootingOrigin;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

     void Shoot()
    {
        range = GameSettingsDatabase.gunRange;
        damage= GameSettingsDatabase.gunDamage;

        //Stores information about "what" was being hit by ray
        RaycastHit hit;

        // ADDING SPRED TO SHOOTING 

        shootingOrigin = bulletSpawnPoint.transform.position;

        shootingDirection = bulletSpawnPoint.transform.forward;
        shootingDirection.x += Random.Range(-spreadFactor, spreadFactor);
        shootingDirection.y += Random.Range(-spreadFactor, spreadFactor);

        if (Physics.Raycast(shootingOrigin, shootingDirection, out hit/*, range*/));
        {
            if (hit.collider!= null)
            Debug.Log("Collision at: " + hit.point + " with object: " + hit.transform.name);

            hitPosition = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Instantiate(shotHolePrefab, hitPosition, Quaternion.identity);


        }
    }





}

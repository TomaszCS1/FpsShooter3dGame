using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 1f;
    public float range = 80f;
    
    public Camera cam;
    public GameObject bulletSpawnPoint;
    public Vector3 hitPosition;

    public GameObject shotHolePrefab;


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
        //Stores information about what was being hit by ray
        RaycastHit hit;

        if (Physics.Raycast(bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.forward, out hit));
        {
            if (hit.collider!= null)
            Debug.Log("Collision at: " + hit.point + " with object: " + hit.transform.name);

            hitPosition = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            Instantiate(shotHolePrefab, hitPosition, Quaternion.identity);


        }
    }





}

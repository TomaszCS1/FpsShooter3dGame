using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float _movementSpeed = 10f;
    public float mouseSensitivity = 2f;

    private float yRotation = 0f;
    private Rigidbody rb;

    private float moveX;
    private float moveZ;

   
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;

    

    }


    // Update is called once per frame
    void Update()
    {
        
        // MOVING WSAD
       float moveZ = Input.GetAxis("Horizontal");
       float moveX = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized * _movementSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

              
    }

    
   
    
}

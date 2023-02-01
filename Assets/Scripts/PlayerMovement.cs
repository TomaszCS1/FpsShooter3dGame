using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float _movementSpeed;
    public float _movementSpeedNormal = 10f;
    public float _movementSpeedCrouching = 5f;

    public float mouseSensitivity = 5f;

    private Rigidbody rb;


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
       float moveZ = Input.GetAxis("Vertical");
       float moveX = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized * _movementSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

              
    }

    
   
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    private float XRotation;
    private float YRotation;

    public Transform playerBody1;
    public Rigidbody rb;

    public Camera cameraMain;

    private float fallingSpeedmultiplier = 4f;
    private float risingSpeedmultiplier = 2.5f;

    [Range(1f, 10f)]
    public float jumpVelocity = 15f;
     


    // Start is called before the first frame update
    void Start()
    {
        //locks cursor in the game window
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //jumping
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jumpOnSpace();
        }

        //jumping mechanics improved
        if (rb.velocity.y < 0f) 
        { rb.velocity += Vector3.up * Physics.gravity.y * (fallingSpeedmultiplier - 1) * Time.deltaTime; }

        else if (rb.velocity.y > 0f) 
        { rb.velocity += Vector3.up * Physics.gravity.y * (risingSpeedmultiplier - 1) * Time.deltaTime; }



        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotates camera around X axis (up and down)
        XRotation += mouseY;
        XRotation = Mathf.Clamp(XRotation, -15f, 45f);
       
        cameraMain.transform.localRotation=Quaternion.Euler(XRotation, 0, 0);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        //rotates player around Y axis (sides)
        YRotation += mouseX;
        playerBody1.rotation = Quaternion.Euler(0, YRotation, 0 );

    }


    private void jumpOnSpace()
    {
        if (rb.transform.position.y  < 5.0f)
        {
            rb.velocity += Vector3.up * jumpVelocity;

        }
    }
}

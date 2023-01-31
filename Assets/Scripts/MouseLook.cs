using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 1f;

    public float XRotation = 0f;

    public Transform playerBody;

    public Camera cameraMain;

    // Start is called before the first frame update
    void Start()
    {
        //locks cursor in the game window
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotates camera around X axis (up and down)
        XRotation += mouseY;
        XRotation = Mathf.Clamp(XRotation, -15f, 45f);
        cameraMain.transform.localRotation=Quaternion.Euler(XRotation, 0, 0);

        //rotates player around Y axis (sides)
        playerBody.Rotate(Vector3.up * mouseX);
       
    }
}

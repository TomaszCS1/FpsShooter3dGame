using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    //referemce to Component: Character controller, enables to control parameter: height 
    //public CharacterController characterController;
    private float normalHeigt = 2.0f;
    private float crouchHeigt = 0.8f;
    float crouchDeltaY;
   

    private Rigidbody rb;
    public Transform playerBody;

    public CapsuleCollider collider;
    public Transform playerBody1;

    // Start is called before the first frame update
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        //characterController.height = normalHeigt;
        rb = GetComponent<Rigidbody>();
        crouchDeltaY =  0.5f ;
        collider= GetComponent<CapsuleCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
           
            collider.height=crouchHeigt;
            playerBody.localScale = new Vector3(1, crouchDeltaY,1);
            
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            
            collider.height = normalHeigt;
            playerBody.localScale = new Vector3(1, 1, 1);

        }


    }

    
}

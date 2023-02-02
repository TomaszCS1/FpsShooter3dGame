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

    public PlayerMovement playerMovement;
    public Gun gun;

    private Rigidbody rb;
    public Transform playerBody;

    public CapsuleCollider collider;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        crouchDeltaY =  0.8f ;
        collider= GetComponent<CapsuleCollider>();
        //nie wiem jak to zadzialalo...(?):
        playerMovement = FindObjectOfType(typeof(PlayerMovement)) as PlayerMovement;
        gun = FindObjectOfType<Gun>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
           
            collider.height=crouchHeigt;
            playerBody.localScale = new Vector3(1, crouchDeltaY,1);
            playerMovement._movementSpeed = playerMovement._movementSpeedCrouching;
            gun.spreadFactor = gun.spreadCrouching;
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            
            collider.height = normalHeigt;
            playerBody.localScale = new Vector3(1, 1, 1);
            playerMovement._movementSpeed = playerMovement._movementSpeedNormal;
            gun.spreadFactor = gun.spreadNormal;

        }


    }

    
}

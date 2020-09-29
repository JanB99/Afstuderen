using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    public bool canMove = true;
    public bool safeSpace = true;
    public OpdrachtMS opdrachten;

    private CharacterController characterController;
    

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x,0, input.axis.y));
            characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction,Vector3.up) - new Vector3(0,9.81f,0)*Time.deltaTime);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SafeSpace")
        {
            safeSpace = !safeSpace;
        }

        if(other.gameObject.tag == "Shop")
        {
            if(opdrachten.status == 3)
            {
                opdrachten.status = 4;
            }
        }

        if(other.gameObject.tag == "ShopExit")
        {
            if(opdrachten.status == 4)
            {
                opdrachten.status = 5;
            }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HandControl : MonoBehaviour
{

    public SteamVR_Action_Boolean grabGrip;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;
    public int treshold;
    public int roll;
    public bool canPickup = false;

    public void Start(){}

    private void OnEnable()
    {
        grabGrip.AddOnStateDownListener(Press, inputSource);
    }

    private void OnDisable()
    {
        grabGrip.RemoveOnStateDownListener(Press, inputSource);
    }

    private void Press(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        roll = Random.Range(1,100);
        if(roll < treshold)
        {
            canPickup = false;
        }
        else
        {
            canPickup = true;
        }
    }


}

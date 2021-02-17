using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
 
    public OpdrachtMS opdrachten;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key")
        {
            if(opdrachten.status == 2)
            {
                opdrachten.status = 3;
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdracht1 : MonoBehaviour
{

    public int numberinzone = 0;
    public OpdrachtMS Opdrachten;

    // Update is called once per frame

    void Update()
    {
        if(numberinzone == 5)
        {
            if(Opdrachten.status == 1)
            {
            Opdrachten.status = 2;
            }
        }
    }

   void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Empty")
        {
            numberinzone++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Empty")
        {
            numberinzone--;
        }
    }
}

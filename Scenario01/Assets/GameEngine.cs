using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public GameObject Ziekte;
    public bool GevenEnergyActive;
    public bool Angst;
    public bool Depressie;
    public bool Blaas;
    public bool BlindeVlekken;
    /*
    public float playerMaxEnergy = 1000;
    public float PlayerEnergy = 1000;
    public float EnergyDecay = 100;
    public float EnergyIncrease = 100;*/

    // Start is called before the first frame update
    void Start()
    {
        if(GevenEnergyActive)
        {
            Ziekte.GetComponent<GevenEnergy>().enabled = true;
        }
        if(Angst)
        {
            Ziekte.GetComponent<Angst>().enabled = true;
        }
        if(Depressie)
        {
            Ziekte.GetComponent<Depressie>().enabled = true;
        }
        /*if(Blaas)
        {
            Ziekte.GetComponent<Blaas>().enabled = true;
        }
        if(BlindeVlekken)
        {
            Ziekte.GetComponent<BlindeVlekken>().enabled = true;
        }*/
    }

 
}

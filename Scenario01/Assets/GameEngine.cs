using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{
    public GameObject Ziekte;
    public bool GevenEnergyActive;
    /*
    public float playerMaxEnergy = 1000;
    public float PlayerEnergy = 1000;
    public float EnergyDecay = 100;
    public float EnergyIncrease = 100;*/

    // Start is called before the first frame update
    void Start()
    {
        //Ziekte.GetComponent<GevenEnergy>().setupEnergySymptoom(playerMaxEnergy,PlayerEnergy,EnergyDecay,EnergyIncrease);
        Ziekte.GetComponent<GevenEnergy>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

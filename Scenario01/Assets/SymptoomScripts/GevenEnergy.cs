using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GevenEnergy : MonoBehaviour
{
    //Global
    public PlayerController playerController;
    public GameObject gameObject;
    public Text uitgeputText;
    public GameObject Panel;

    //Local
    //Energy
    public float playerMaxEnergy;
    public float PlayerEnergy;
    public float EnergyDecay;
    public float EnergyIncrease;
    private float TimeMoved;
    private float TimeStill;

    //Movement
    private Vector3 lastPosition;

    public void setupEnergySymptoom(float playerMaxEnergy, float PlayerEnergy, float EnergyDecay, float EnergyIncrease)
    {
        this.playerMaxEnergy = playerMaxEnergy;
        this.PlayerEnergy = PlayerEnergy;
        this.EnergyDecay = EnergyDecay;
        this.EnergyIncrease = EnergyIncrease;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController.speed = 1;
        lastPosition = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if(lastPosition != gameObject.transform.position)
        {
            TimeStill = 0;
            TimeMoved += Time.deltaTime;
            
            if(TimeMoved > 1)
            { 
                if(PlayerEnergy > 0)
                {
                    PlayerEnergy -= EnergyDecay;
                    if(PlayerEnergy < 0)
                    {
                        PlayerEnergy = 0;
                    }
                }
                if(PlayerEnergy == 0)
                {
                    playerController.canMove = false;
                    uitgeputText.gameObject.SetActive(true);
                    Panel.gameObject.SetActive(true);
                }
                
                TimeMoved = 0;
            }
        }
        else
        {
            TimeStill += Time.deltaTime;
            TimeMoved = 0;

            if(PlayerEnergy > 0)
            {
                playerController.canMove = true;
                uitgeputText.gameObject.SetActive(false);
                Panel.gameObject.SetActive(false);
            }

            if(TimeStill > 5)
            {
                PlayerEnergy += EnergyIncrease;
                if(PlayerEnergy > playerMaxEnergy)
                {
                    PlayerEnergy = playerMaxEnergy;
                }
                TimeStill = 0;
            }
        }
        lastPosition = gameObject.transform.position;
    }
}

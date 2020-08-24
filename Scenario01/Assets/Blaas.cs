using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blaas : MonoBehaviour
{

    public int BlaasIncrease = 10;
    public int MaxBlaasVolume = 1000;
    public PlayerController playerController;
    public Text Text;
    public GameObject panel;
    public GameObject Image;
    public Slider slider;

    private bool SafeSpace;
    public int CurrentBlaasVolume = 0;

    void Start()
    {
        InvokeRepeating("EverySecond",0,1);
    }


    // Update is called once per frame
    void Update()
    {
        SafeSpace = playerController.safeSpace;
        slider.value = (float)CurrentBlaasVolume / 1000f;
    }

    private void EverySecond()
    {
        if(!SafeSpace)
        {
            if(CurrentBlaasVolume < MaxBlaasVolume)
            {
                if(CurrentBlaasVolume > 100 && CurrentBlaasVolume < 300)
                {
                    CurrentBlaasVolume += BlaasIncrease;
                }
                else if(CurrentBlaasVolume > 300 && CurrentBlaasVolume < 600)
                {
                    panel.gameObject.SetActive(true);
                    Image.gameObject.SetActive(true);
                    CurrentBlaasVolume += BlaasIncrease;
                }   
                else if(CurrentBlaasVolume > 600 && CurrentBlaasVolume < 900)
                {
                    Text.gameObject.SetActive(true);
                    Text.text = "Ik kan het bijna niet meer ophouden. Ik moet naar de WC.";
                    CurrentBlaasVolume += BlaasIncrease;
                }
                else
                {
                    CurrentBlaasVolume += BlaasIncrease;
                }

                if(CurrentBlaasVolume > MaxBlaasVolume)
                {
                    Text.text = "Kon het niet meer ophouden. Ik heb in mijn broek geplast.";
                    playerController.speed = 0.8f;
                }
                
            }
        }
        else
        {
            Text.gameObject.SetActive(false);
            Image.gameObject.SetActive(false);
            CurrentBlaasVolume = 0;
            playerController.speed = 1;
        }

    }


}

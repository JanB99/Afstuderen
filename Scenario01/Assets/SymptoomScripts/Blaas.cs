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
    public AudioClip currentClip;
    public AudioSource choice;

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
                     if(!choice.isPlaying)
                        {
                        choice.clip = currentClip;
                        choice.Play();
                        }
                }
                else if(CurrentBlaasVolume > 300 && CurrentBlaasVolume < 600)
                {
                    
                    Image.gameObject.SetActive(true);
                    choice.volume = 0.66f;
                    CurrentBlaasVolume += BlaasIncrease;
                }   
                else if(CurrentBlaasVolume > 600 && CurrentBlaasVolume < 900)
                {
                    panel.gameObject.SetActive(true);
                    Text.gameObject.SetActive(true);
                    choice.volume = 1.0f;
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
            panel.gameObject.SetActive(false);
            choice.Stop();
            choice.volume = 0.33f;
            CurrentBlaasVolume = 0;
            playerController.speed = 1;
        }

    }


}

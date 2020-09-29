using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpdrachtMS : MonoBehaviour
{
    public GameObject opdracht1;
    public GameObject opdracht2;
    public GameObject opdracht3;
    public GameObject opdracht4;
    public GameObject opdracht5;

    public int status = 1;

    // Update is called once per frame
    void Update()
    {
        switch (status)
        {
            case 0:
                opdracht1.SetActive(false);
                opdracht2.SetActive(false);
                opdracht3.SetActive(false);
                opdracht4.SetActive(false);
                opdracht5.SetActive(false);
                break;
            case 1:
                opdracht1.SetActive(true);
                opdracht2.SetActive(false);
                opdracht3.SetActive(false);
                opdracht4.SetActive(false);
                opdracht5.SetActive(false);
                break;
            case 2:
                opdracht1.SetActive(false);
                opdracht2.SetActive(true);
                opdracht3.SetActive(false);
                opdracht4.SetActive(false);
                opdracht5.SetActive(false);
                break;
            case 3:
                opdracht1.SetActive(false);
                opdracht2.SetActive(false);
                opdracht3.SetActive(true);
                opdracht4.SetActive(false);
                opdracht5.SetActive(false);
                break;
            case 4:
                opdracht1.SetActive(false);
                opdracht2.SetActive(false);
                opdracht3.SetActive(false);
                opdracht4.SetActive(true);
                opdracht5.SetActive(false);
                break;
            case 5:
                opdracht1.SetActive(false);
                opdracht2.SetActive(false);
                opdracht3.SetActive(false);
                opdracht4.SetActive(false);
                opdracht5.SetActive(true);
                break;
            default:
                break;
        }
    }
}

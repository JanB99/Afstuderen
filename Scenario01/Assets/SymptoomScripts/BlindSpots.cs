using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindSpots : MonoBehaviour
{
    [Header("Blindspot Setup")]
    public GameObject BlindspotUL;
    public GameObject BlindspotUM;
    public GameObject BlindspotUR;
    public GameObject BlindspotML;
    public GameObject BlindspotMM;
    public GameObject BlindspotMR;
    public GameObject BlindspotBL;
    public GameObject BlindspotBM;
    public GameObject BlindspotBR;

    [Header("Patient Setup")]
    public int NRBlindspots1_9 = 1;
    public float MaxSize1_5;


    private float size;
    private int count;
    private List<GameObject> Blindspots;

    // Start is called before the first frame update
    void Start()
    {
        Blindspots = new List<GameObject>();
        FillList();
        GameObject ChosenBlindspot;

        for (int i = NRBlindspots1_9; i > 0; i--)
        {
            
            count = Blindspots.Count;
            ChosenBlindspot = Blindspots[Random.Range(0,count)];
            Blindspots.Remove(ChosenBlindspot);
            size = (int)Random.Range(1,MaxSize1_5);
            switch (size)
            {
                case 1:
                    ChosenBlindspot.transform.localScale = new Vector3(0.01f,0.01f,0.01f);
                    break;
                case 2:
                    ChosenBlindspot.transform.localScale = new Vector3(0.02f,0.02f,0.02f);
                    break;
                case 3:
                    ChosenBlindspot.transform.localScale = new Vector3(0.03f,0.03f,0.03f);
                    break;
                case 4:
                    ChosenBlindspot.transform.localScale = new Vector3(0.04f,0.04f,0.04f);
                    break;
                case 5:
                    ChosenBlindspot.transform.localScale = new Vector3(0.05f,0.05f,0.05f);
                    break;
                default:
                    break;
            }
            ChosenBlindspot.SetActive(true);
        }
    }


    private void FillList()
    {
        Blindspots.Add(BlindspotBL);
        Blindspots.Add(BlindspotBR);
        Blindspots.Add(BlindspotBM);
        Blindspots.Add(BlindspotUL);
        Blindspots.Add(BlindspotUR);
        Blindspots.Add(BlindspotUM);
        Blindspots.Add(BlindspotML);
        Blindspots.Add(BlindspotMR);
        Blindspots.Add(BlindspotMM);
    }

}

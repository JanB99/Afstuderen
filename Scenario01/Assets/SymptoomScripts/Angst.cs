using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angst : MonoBehaviour
{
    public AudioSource _Audio;
    public float Interval;
    public float MaxVolume0_1;
    private Object[] List;
    private AudioClip currentClip;
    private AudioSource choice;
    private float lastTimeStamp;
    private float currentVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {

        List = Resources.LoadAll("Angst",typeof(AudioClip));
        currentClip = List[Random.Range(0,List.Length)] as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastTimeStamp >= Interval)
        {
            if(!_Audio.isPlaying)
            {
            lastTimeStamp = Time.time;
            currentVolume = Random.Range(0.20f,MaxVolume0_1);
            _Audio.volume = currentVolume;
            currentClip = List[Random.Range(0,List.Length)] as AudioClip;
            _Audio.clip = currentClip;
            _Audio.Play();
            }
        }
    }
}

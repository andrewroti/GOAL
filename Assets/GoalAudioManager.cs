using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalAudioManager : MonoBehaviour
{

    private AudioSource _goalAudio;
    void Start()
    {
        _goalAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Goal();
    }
    public void Goal()
    {
        GetComponent<AudioSource>().Play();
    }
  
}

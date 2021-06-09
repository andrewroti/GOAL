using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickSound : MonoBehaviour
{
    private AudioSource _kick;
    [SerializeField]
    private bool kick = false;
   

    // Update is called once per frame
    void Update()
    {
        if (kick == true)
        {
            _kick = GetComponent<AudioSource>();
            _kick.Play();

            kick = false;
        }
    }
    public void Kick()
    {

        kick = true;
        
      
    }
}

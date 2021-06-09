using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private AudioSource _goal;
    void Awake()
    {

        DontDestroyOnLoad(transform.gameObject);
           
        
    }

    private void Start()
    {
        _goal = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(this.gameObject);
        }
    }
}

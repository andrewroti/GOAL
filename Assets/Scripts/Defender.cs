using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    private DefenderSpawn ds;
    private  AudioSource _kick;
   [SerializeField]
    private bool _liveBall = false;
    private void Start()
    {
        ds = GameObject.Find("Defender Spawn").GetComponent<DefenderSpawn>();
      
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            _liveBall = true;
            StartCoroutine(SelfDestruct());
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            ds.DefenderDown();

            Destroy(this.gameObject);
           
            

            
        }
    }
    IEnumerator SelfDestruct()
    {

        while (_liveBall == true)
        {
            yield return new WaitForSeconds(9);
            Destroy(this.gameObject);
            ds.DefenderDown();
        }
       
    }
   

}
    

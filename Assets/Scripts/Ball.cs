using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private bool _liveBall = false;
   [SerializeField]
    private float _kickOff = 500f;
    private Rigidbody2D _rb;
    private Player player;
    private Goalie goalie;
    private Game_Manager _gm;
    private AudioSource _goalCheer;
    [SerializeField]
    private bool _held = false;
    [SerializeField]
    private float startTime = 0f;
   [SerializeField]
    private float holdTime = 5.0f;
    private KickSound _kick;
   
 
    void Start()
    {
        transform.position = new Vector3(-7f, 0, 0);
        Time.timeScale = 1;
       
        _rb = GetComponent<Rigidbody2D>();
      

        player = GameObject.Find("Player").GetComponent<Player>();
        goalie = GameObject.Find("Goalie").GetComponent<Goalie>();
        _gm = GameObject.Find("Game Manager").GetComponent<Game_Manager>();
        _kick = GameObject.Find("KickSound").GetComponent<KickSound>();





    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) && _liveBall == false)
        {
            _rb.AddForce(transform.right * _kickOff);
            _liveBall = true;
        }
        
        
        
    
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Goal")
        {
            player.Goal();
            _gm.DeadBall();
            _goalCheer = GetComponent<AudioSource>();
            _goalCheer.Play();    
        }
        if(other.tag == "Own Goal")
        {
            goalie.Goals();
            _gm.DeadBall();
            
        }
       
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Defender")
        {

            _kick.Kick();
        }
    }

    
   
   
    
}

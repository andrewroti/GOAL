using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    [SerializeField]
    private bool _liveGame = false;
    [SerializeField]
    private static int goals = 0;
    private UI_Manager _ui;
    private AudioSource _kick;
    private Goalie _goalie;
   
    void Start()
    {
        transform.position = new Vector3(-10f, -0.6f, 0);
        _rigidBody = GetComponent<Rigidbody2D>();

        _rigidBody.gravityScale = 0;

        _ui = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        _goalie = GameObject.Find("Goalie").GetComponent<Goalie>();
        

    }

    // Update is called once per frame
    void Update()
    {
        Floor();
        ManualMovement();

       
        
        if (Input.GetKeyDown(KeyCode.DownArrow) && _liveGame == false)
        {

            _rigidBody.gravityScale = 0;
            _liveGame = true;
            _kick = GetComponent<AudioSource>();
            _kick.Play();
        }
        if (goals == 11 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            goals = 0;
            _goalie.NewGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goals = 0;
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            _kick = GetComponent<AudioSource>();
            _kick.Play();
        }
    }


    private void Floor()
    {
        if (transform.position.y <= -3.1f)
        {
            transform.position = new Vector3(transform.position.x, -3.09f, 0);
        }
        if(transform.position.y >= 1.9f)
        {
            transform.position = new Vector3(transform.position.x, 1.89f, 0);
        }
    }
    public void Goal()
    {
        goals = goals + 1;
        _ui.GoalsFor(goals);
        _ui.GoalsForTrue();

       
    }
    public void NewGame()
    {
        goals = 0;
    }
    void ManualMovement()
    {
        if (_liveGame)
        {
            float verticalAxis = Input.GetAxis("Vertical");
            transform.Translate(Vector3.up * verticalAxis * 7.5f * Time.deltaTime);
        }
        
       
    }
  
}

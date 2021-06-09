using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    // private bool _liveBall = false;
    [SerializeField]
    private bool _bottom;
    [SerializeField]
    private static int goals;
    private float _randomSpeed;
    private UI_Manager _ui;
    private Rigidbody2D rb;
    private AudioSource _kick;
    private Player _player;
   

    void Start()
    {
        transform.position = new Vector3(5f, 0f, 0);
        _bottom = true;
        _randomSpeed = Random.Range(0.5f, 3.0f);
        rb = GetComponent<Rigidbody2D>();  
        _ui = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        _player = GameObject.Find("Player").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goals == 11 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            goals = 0;
            _player.NewGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            goals = 0;
        }

        if (transform.position.y <= -0.2f)
        {
            _bottom = true;
        }

        if (_bottom)
        {
            transform.Translate(Vector2.down * _randomSpeed * Time.deltaTime);
        } 
        if(transform.position.y >= 2.3f)
        {
            _bottom = false;

        }
        if (!_bottom)
        {
            transform.Translate(Vector2.up * _randomSpeed * Time.deltaTime);
        }
       


    }
    public void Goals()
    {
        goals = goals + 1;

       
       
        _ui.GoalsAgainst(goals);
        _ui.GoalAgainstTrue();

        
    }
    public void NewGame()
    {
        goals = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            _kick = GetComponent<AudioSource>();
            _kick.Play();
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    //private bool _goalScored = false;
    private bool _deadBall = false;
    [SerializeField]
    private bool _held = false;

    void Start()
    {
        _deadBall = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.DownArrow) && _deadBall)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        DestroyCondition();
    }
   
    public void DeadBall()
    {
        _deadBall = true;
    }
    private void DestroyCondition()
    {

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            _held = true;
            if (_held == true)
            {
                StartCoroutine(ResetBall());

            }

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            _held = false;

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            _held = false;

        }
    }
    IEnumerator ResetBall()
    {

        yield return new WaitForSeconds(3);
        if (_held == false)
        {
            StopAllCoroutines();
        }
        if (_held == true)
        {
            SceneManager.LoadScene(0);
        }

    }
}

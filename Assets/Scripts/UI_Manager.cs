using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private Text _goalsAgainst;
    [SerializeField]
    private Text _timer;
    [SerializeField]
    private Text _goalsFor;
    [SerializeField]
    private Text _goal;
    [SerializeField]
    private Text _goal2;
    [SerializeField]
    private Text _defeat;
    [SerializeField]
    private Text _defeat2;
    private Goalie goalie;

   
    private Player player;
    private static int opponentGoals;
    private static int playerGoals;
    public static int _timeLeft = 90;
    private static bool _time = true;
    private bool _goalFor = false;
    private bool defeat = false;
    private bool _goalAgainst = false;
   
    void Start()
    {
        Time.timeScale = 1;
        //StartCoroutine(Timer());
        _goalsAgainst.text = ("");
        _goalsFor.text = ("");
        _goal.text = ("");
        _goal2.text = ("");
        _defeat.text = ("");
        _defeat2.text = ("");
       
       // _timer.text = ("");
        goalie = GameObject.Find("Goalie").GetComponent<Goalie>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        GoalsAgainst(opponentGoals);
        GoalsFor(playerGoals);
        //_timer.text = ("" + _timeLeft);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerGoals = 0;
            opponentGoals = 0;
        }
    }

    public void GoalsAgainst(int goalsAgainst)
    {
        opponentGoals = goalsAgainst;
        _goalsAgainst.text = ("" + goalsAgainst);

       if(goalsAgainst < 11 && _goalAgainst == true)
        {
          
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
        }
        if(goalsAgainst == 11)
        {
            defeat = true;
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
        }
        if(goalsAgainst == 11 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            opponentGoals = 0;
            playerGoals = 0;
        }

    }
    public void GoalsFor(int goalsFor)
    {
        playerGoals = goalsFor;
        _goalsFor.text = ("" + goalsFor);
        if (goalsFor < 11 && _goalFor == true)
        {
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
        }
        if(goalsFor == 11)
        {
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
        }
        if(goalsFor == 11 && Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            playerGoals = 0;
            opponentGoals = 0;
        }
      
    }
    public void GoalsForTrue()
    {
        _goalFor = true;
    }
    public void GoalAgainstTrue()
    {
        _goalAgainst = true;
    }
    public void Victory()
    {
        StartCoroutine(VictoryTime());
    }
   // IEnumerator Timer()
    //{
      //  while (_time == true)
        //{
          //  yield return new WaitForSeconds(1);
            //_timeLeft--;

            //if(_timeLeft == 0)
            //{
              //  _time = false;
                //StopAllCoroutines();
            //}
        //}
        
    //}
    IEnumerator Goal()
    {
        if (_goalFor == true)
        {
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("GOAL!");
            _goal2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goalFor = false;
        }
     
    }
    IEnumerator VictoryTime()
    {
        if (_goalFor == true)
        {
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goal.text = ("VICTORY!");
            _goal2.text = ("VICTORY!");
            yield return new WaitForSeconds(1f);
            _goal.text = ("");
            _goal2.text = ("");
            yield return new WaitForSeconds(1f);
            _goalFor = false;
        }
    }
    IEnumerator Defeat()
    {
        if(defeat == true)
        {
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("DEFEAT!");
            _defeat2.text = ("DEFEAT!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            defeat = false;
        }
     
    }
    IEnumerator GoalAgainst()
    {
        if(_goalAgainst == true)
        {
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("GOAL!");
            _defeat2.text = ("GOAL!");
            yield return new WaitForSeconds(1f);
            _defeat.text = ("");
            _defeat2.text = ("");
            yield return new WaitForSeconds(1f);
            _goalAgainst = false;
        }
    }
}

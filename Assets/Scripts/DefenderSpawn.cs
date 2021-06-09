using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    
    [SerializeField]
    private GameObject _defender;
   [SerializeField]
    private int _defendersLeft = 11;
   
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(_defendersLeft < 11)
        {
            StartCoroutine(Substitution());
        }
    }
    public void DefenderDown()
    {
        _defendersLeft = _defendersLeft - 1;
        
    }
    IEnumerator Substitution()
    {
        yield return new WaitForSeconds(0.1f);
        float _randomX = Random.Range(-14f, -5f);
       float _randomY = Random.Range(-1.4f, 6.8f);
        Instantiate(_defender, new Vector3(_randomX, _randomY, 0), Quaternion.identity);
        _defendersLeft = _defendersLeft + 1;

        if(_defendersLeft >= 11)
        {

            StopAllCoroutines();
        }
    }
}

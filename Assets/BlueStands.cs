using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueStands : MonoBehaviour
{
    [SerializeField]
    private  bool _bottom;
    private float _randomSpeed;
    void Start()
    {
        transform.position = new Vector3(-6.2f, -3.5f, 0);
        _bottom = true;
        _randomSpeed = Random.Range(1f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -3.6f)
        {
            _bottom = true;
        }

        if (_bottom)
        {
            transform.Translate(Vector2.up * _randomSpeed * Time.deltaTime);
        }
        if (transform.position.y >= -3.4f)
        {
            _bottom = false;

        }
        if (!_bottom)
        {
            transform.Translate(Vector2.down * _randomSpeed * Time.deltaTime);
        }
    }
}


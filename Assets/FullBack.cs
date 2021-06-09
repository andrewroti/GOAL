using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullBack : MonoBehaviour
{
    [SerializeField]
    private bool _bottom;
    private float _randomSpeed;
    private AudioSource _kick;
    void Start()
    {
        transform.position = new Vector3(7, -3.55f, 0);
        _bottom = true;
        _randomSpeed = Random.Range(0.5f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5f)
        {
            _bottom = true;
        }

        if (_bottom)
        {
            transform.Translate(Vector2.up * _randomSpeed * Time.deltaTime);
        }
        if (transform.position.y >= -2f)
        {
            _bottom = false;

        }
        if (!_bottom)
        {
            transform.Translate(Vector2.down * _randomSpeed * Time.deltaTime);
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
}

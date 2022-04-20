using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    AudioSource carBeep;

    private void Start()
    {
        carBeep = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, -6), step);

        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            carBeep.Play(0);
        }

        if(collision.tag == "Enemy" /*&& this.gameObject.name == "reaperClone"*/)
        {
            Destroy(collision.gameObject);
        }
    }


}

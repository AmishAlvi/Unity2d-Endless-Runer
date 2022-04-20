using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -5.94)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + -3, transform.position.y), 0.99f);
        }

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 5.94)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + 3, transform.position.y), 0.99f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            SceneManager.LoadScene("EndScene");
        }
    }

}

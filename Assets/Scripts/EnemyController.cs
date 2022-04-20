using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject ReaperEnemy;
    public GameObject LongEnemy;
    public GameObject Player;
    public float EnemyTimer = 0.5f;
    //public float LongTimer = 2f;
    public float ReaperTimer = 6.66f;
    private GameObject enemyClone;
    private GameObject reaperClone;
    private readonly Color[] colors = { Color.white, Color.magenta, Color.yellow, Color.red, Color.cyan };

    private void Start()
    {
        
    }

    private void Update()
    {
        EnemyTimer -= Time.deltaTime;
        //LongTimer -= Time.deltaTime;
        ReaperTimer -= Time.deltaTime;
        if (EnemyTimer <= 0f)
        {
            enemyClone = Instantiate(Enemy, new Vector3(Random.Range(-2, 3) * 3, 8f, 0f), Quaternion.Euler(new Vector3(0, 0, 180))) as GameObject;
            enemyClone.GetComponent<SpriteRenderer>().color = colors[Random.Range(0, 5)];
            enemyClone = Instantiate(LongEnemy, new Vector3(Random.Range(-2, 3) * 3, 8f, 0f), Quaternion.Euler(new Vector3(0, 0, 180))) as GameObject;

            EnemyTimer = 0.5f;
        }

        /*if (LongTimer <= 0f)
        {
            enemyClone = Instantiate(LongEnemy, new Vector3(Random.Range(-2, 3) * 3, 8f, 0f), Quaternion.Euler(new Vector3(0, 0, 180))) as GameObject;
            LongTimer = 2f;
        }*/


        if (ReaperTimer <= 0f)
        {
            reaperClone = Instantiate(ReaperEnemy, new Vector3(Player.transform.position.x, 8f, 0f), transform.rotation) as GameObject;
            ReaperTimer = 6.66f;
        }

    }
}

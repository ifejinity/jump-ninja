using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : MonoBehaviour
{

    public GameObject obstacle, target, enemy;
    public float obstaclespawninterval = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstacles");
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            StopCoroutine("SpawnObstacles");
        }
    }

    private void SpawnObstacle()
    {
        int random = Random.Range(1,4);
        // float ranenemy = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y;

        if(random == 1)
        {
            Instantiate(target, new Vector3(transform.position.x,
            2.6f, 0), Quaternion.identity);
        }

        if(random == 2)
        {
            Instantiate(obstacle, new Vector3(transform.position.x,
            2.6f, 0), Quaternion.identity);
        }

        if(random == 3)
        {
            Instantiate(enemy, new Vector3(transform.position.x,
            2.6f, 0), Quaternion.identity);
        }
    }
    
    IEnumerator SpawnObstacles()
    {
        while(true)
        {
            yield return new WaitForSeconds(obstaclespawninterval);
            SpawnObstacle();
        }
    }
}

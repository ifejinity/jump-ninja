using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Ground1, Ground2, Ground3, Ground4, Ground5, Ground6, Ground7, Ground8, coin1;
    bool hasGround = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!hasGround)
        {
            SpawnGround();
            hasGround = true;
        }
    }

    public void SpawnGround()
    {
        int randomNum = Random.Range(1,9);

        if(randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 14.5f,
            -0.5f, 0), Quaternion.identity);

            Instantiate(coin1, new Vector3(transform.position.x + 14.5f,
            0f, 0), Quaternion.identity);
        }
        
        if(randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 14.5f,
            1f, 0), Quaternion.identity);
        }

        if(randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 14.5f,
            1.5f, 0), Quaternion.identity);

            Instantiate(coin1, new Vector3(transform.position.x + 14.5f,
            2f, 0), Quaternion.identity);
        }

        if(randomNum == 4)
        {
            Instantiate(Ground4, new Vector3(transform.position.x + 14.5f,
            2f, 0), Quaternion.identity);

        }

        if(randomNum == 5)
        {
            Instantiate(Ground5, new Vector3(transform.position.x + 14.5f,
            -0.5f, 0), Quaternion.identity);
        }
        
        if(randomNum == 6)
        {
            Instantiate(Ground6, new Vector3(transform.position.x + 14.5f,
            1f, 0), Quaternion.identity);

             Instantiate(coin1, new Vector3(transform.position.x + 14.5f,
            1.5f, 0), Quaternion.identity);
        }

        if(randomNum == 7)
        {
            Instantiate(Ground7, new Vector3(transform.position.x + 14,
            1.5f, 0), Quaternion.identity);
        }

        if(randomNum == 8)
        {
            Instantiate(Ground8, new Vector3(transform.position.x + 14,
            2f, 0), Quaternion.identity);

            Instantiate(coin1, new Vector3(transform.position.x + 14.5f,
            2.5f, 0), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            hasGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            hasGround = false;
        }
    }
}

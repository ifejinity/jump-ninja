using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Obstacles"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Kunai"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacles"))
        {
            Destroy(collision.gameObject);
        }

         if(collision.gameObject.CompareTag("Kunai"))
        {
            Destroy(collision.gameObject);
        }

         if(collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject); 
        }
    }
}

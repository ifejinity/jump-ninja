using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCoin");
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isGameOver)
        {
            StopCoroutine("SpawnCoin");
        }
    }
    
    private void SpawnCoins()
    {
        int coinnumber = Random.Range(5,10);
        while(i < coinnumber)
        {
            Instantiate(coin, new Vector3(transform.position.x,
            2.6f, 0), Quaternion.identity);
            i++;
        }
        i = 0;
    }

    IEnumerator SpawnCoin()
    {
        while(true)
        {
            SpawnCoins();
            yield return new WaitForSeconds(10);
        }
    }
}

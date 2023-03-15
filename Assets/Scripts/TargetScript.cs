using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public GameObject Particles, Particles1, Particles2;
    Animator anim;
    [SerializeField] private Animator targetanim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if(collision.gameObject.CompareTag("Player"))
        // {
        //     GetComponent<BoxCollider2D> ().enabled = false;
        // } 

        if (collision.gameObject.tag == "Kunai")
        {
            if(PlayerPrefs.GetInt("player")==0)
            {
                Instantiate(Particles, transform.position, Quaternion.identity);
            }

            if(PlayerPrefs.GetInt("player")==1)
            {
                Instantiate(Particles1, transform.position, Quaternion.identity);
            }

            if(PlayerPrefs.GetInt("player")==2)
            {
                Instantiate(Particles2, transform.position, Quaternion.identity);
            }

            Destroy(gameObject, 0.5f);
            targetanim.SetTrigger("slice");
            Destroy(collision.gameObject);

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 1")
            {
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score =  
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score + 100;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 2")
            {
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score =  
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score + 200;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 3")
            {
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score =  
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score + 300;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 4")
            {
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score =  
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score + 400;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 5")
            {
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score =  
                GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score + 500;
            }
        }
    }
}

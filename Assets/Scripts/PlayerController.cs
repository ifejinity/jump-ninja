using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float runSpeed;
    private int jumpcount = 0;
    private bool canjump = true;
    Animator anim;
    public bool isGameOver = false;
    public GameObject GameOverPanel, scoreText, Kunai, jutsu;
    public Text FinalScoreText, HighScoreText,LevelText, cointext;
    Vector2 Kunaipos, jutsupos;
    public float firerate = 1f;
    float nextfire;
    int coin,coins;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        StartCoroutine("IncreaseGameSpeed");
        coins = PlayerPrefs.GetInt("Coins");
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "" + coin;

            if(runSpeed >= 5)
            {
                LevelText.text = "LEVEL 1";
            }

            if(runSpeed >= 6)
            {
                LevelText.text = "LEVEL 2";
            }

            if(runSpeed >= 7)
            {
                LevelText.text = "LEVEL 3";
            }

            if(runSpeed >= 8)
            {
                LevelText.text = "LEVEL 4";
            }

            if(runSpeed >= 9)
            {
                LevelText.text = "LEVEL 5";
            }

        if(!isGameOver)
        {
             transform.position = Vector3.right * runSpeed * Time.deltaTime + transform.position;
        }

        if(jumpcount == 2)
        {
            canjump = false;
        }

        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().
        isGameOver)
        {
            PlayerPrefs.SetInt("Coins", coin + coins);
        }
    }

    void fire()
    {
        nextfire = Time.time + firerate;
        Kunaipos = transform.position;
        Kunaipos += new Vector2(+5f,+2f);

        jutsupos = transform.position;
        jutsupos += new Vector2(+0f,-0f);
        int skill = Random.Range(1,3);

        if(skill == 1)
        {
            Instantiate(Kunai, Kunaipos, Quaternion.identity);
        }

        if(skill == 2)
        {
            Instantiate(jutsu, jutsupos, Quaternion.identity);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        anim.SetTrigger("death");
        StopCoroutine("IncreaseGameSpeed");
        StartCoroutine("showGameOverPanel");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coin += 1;
            Destroy(collision.gameObject); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            jumpcount = 0;
            canjump = true;
        }

        if(collision.gameObject.CompareTag("Obstacles"))
        {
            GameOver();
        }

        if(collision.gameObject.CompareTag("Bottom Detector"))
        {
            GameOver();
        }      
        if(collision.gameObject.CompareTag("Enemy"))
        {
            GameOver();
        } 
    }

    IEnumerator IncreaseGameSpeed()
    {
        while(true)
        {
            yield return new WaitForSeconds(18);
            runSpeed += 0.2f;
            if (firerate >= 0.5)
            {
                firerate -= 0.1f;
            }
            if(GameObject.Find("GroundSpawner").GetComponent<ObstaclesSpawner>().
            obstaclespawninterval > 3)
            {
                GameObject.Find("GroundSpawner").GetComponent<ObstaclesSpawner>().
                obstaclespawninterval -= 0.2f;
            }
        }
    }

    IEnumerator showGameOverPanel()
    {
        yield return new WaitForSeconds(1);
        GameOverPanel.SetActive(true);
        scoreText.SetActive(false);

        FinalScoreText.text = "Score: " + GameObject.Find("ScoreDetector").
        GetComponent<ScoreSystem>().score;
        HighScoreText.text = "High score: " + PlayerPrefs.GetInt("Highscore");
    }

    public void Jump()
    {
        if(canjump && !isGameOver)
        {
            rb2d.velocity = Vector3.up * 10f;
            anim.SetTrigger("jump");
            jumpcount += 1;
        }
    }

    public void Attack()
    {
        if(jumpcount==0)
        {
            if(Time.time > nextfire)
            {
                fire();
                anim.SetTrigger("attack");
            }
        }

        if(jumpcount > 0)
        {
            if(Time.time > nextfire)
            {
                anim.SetTrigger("jumpattack");
                fire();
            }
        }
    }
}

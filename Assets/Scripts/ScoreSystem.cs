using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float pointIncPerSecond;

    // Start is called before the first frame update

    void Start()
    {
        score = 0f;
        pointIncPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)score + "";
        score += pointIncPerSecond * Time.deltaTime;

        if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().
        isGameOver)
        {
            if(PlayerPrefs.GetInt("Highscore") < (int)score)
            {
                PlayerPrefs.SetInt("Highscore", (int)score);
                Debug.Log("New High score is " + (int)score);
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 1")
            {
                score = (int)score + 100;
                scoreText.text = "" + (int)score;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 2")
            {
                score = (int)score + 200;
                scoreText.text = "" + (int)score;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 3")
            {
                score = (int)score + 300;
                scoreText.text = "" + (int)score;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 4")
            {
                score = (int)score + 400;
                scoreText.text = "" + (int)score;
            }

            if(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().LevelText.text == "LEVEL 5")
            {
                score = (int)score + 500;
                scoreText.text = "" + (int)score;
            }
        }
    }
}

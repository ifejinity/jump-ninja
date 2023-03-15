using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScripts : MonoBehaviour
{
    public Text HighScoreText, cointext;
    [SerializeField] GameObject Info;
    [SerializeField] GameObject Game;
    public GameObject ninja1, ninja2, ninjadef;
    public Slider progress;
    int delay = 0;

    void Start()
    {
        HighScoreText.text = "" + PlayerPrefs.GetInt("Highscore");
        cointext.text = "" + PlayerPrefs.GetInt("Coins");
        progress.value = 0;

        if(PlayerPrefs.GetInt("player") == 1)
        {
            ninja1.SetActive(true);
            Destroy(ninja2);
            Destroy(ninjadef);
        }
        if(PlayerPrefs.GetInt("player") == 2)
        {
            ninja2.SetActive(true);
            Destroy(ninja1);
            Destroy(ninjadef);
        }
        if(PlayerPrefs.GetInt("player") == 0)
        {
            ninjadef.SetActive(true);
            Destroy(ninja2);
            Destroy(ninja1);
        }
    }

    void Update()
    {
        
    }

    public void LoadGameScene()
    {
        Game.SetActive(true);
        if(progress.value == 0)
        {
            StartCoroutine("GameLoad");
        }
        if(progress.value == 5)
        {
            StopCoroutine("GameLoad");
            if(PlayerPrefs.GetInt("player") == 1)
            {
                SceneManager.LoadScene("Assets/Scenes/Game 1.unity");
            }
            if(PlayerPrefs.GetInt("player") == 2)
            {
                SceneManager.LoadScene("Assets/Scenes/Game 2.unity");
            }
            if(PlayerPrefs.GetInt("player") == 0)
            {
                SceneManager.LoadScene("Assets/Scenes/Game.unity");
            }
        }
    }

    public void testing()
    {
        PlayerPrefs.SetInt("Coins", 32000);
        cointext.text = "" + PlayerPrefs.GetInt("Coins");
    }

    IEnumerator GameLoad()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            progress.value +=1;
            LoadGameScene();
        }
    }

    public void Shop()
    {
        if (delay == 0)
        {
            StartCoroutine("Delay");
        }
        if(delay > 1)
        {
            SceneManager.LoadScene("Assets/Scenes/Shop.unity");
            StopCoroutine("Delay");
        }
    }

    public void ShowInfo()
    {
        Info.SetActive(true);
    }

    public void CloseInfo()
    {
        Info.SetActive(false);
    }

    IEnumerator Delay()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            delay +=1;
            Shop();
        }
    }
}
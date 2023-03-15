using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Assets/Scenes/Main Menu.unity");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
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

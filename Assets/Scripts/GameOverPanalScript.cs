using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Assets/Scenes/Main Menu.unity");
    }

    public void Replay()
    {
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

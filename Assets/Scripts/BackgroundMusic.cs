using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic Game;

    void Start()
    {
        if(Game == null)
        {
            DontDestroyOnLoad(Game);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

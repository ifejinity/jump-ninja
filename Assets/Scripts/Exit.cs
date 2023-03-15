using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] GameObject exitOverlay;

    public void exit()
    {
        exitOverlay.SetActive(true);
    }

    public void no()
    {
        exitOverlay.SetActive(false);
    }

    public void yes()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public GameObject DefJump, DefAttack, Ninja1Jump, Ninja2Jump, Ninja1Attack, Ninja2Attack, defplayer, ninja1player, ninja2player;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("player")==0)
        {
            DefAttack.SetActive(true);
            DefJump.SetActive(true);
            defplayer.SetActive(true);
            Destroy(ninja1player);
            Destroy(Ninja1Attack);
            Destroy(Ninja1Jump);
            Destroy(ninja2player);
            Destroy(Ninja2Attack);
            Destroy(Ninja2Jump);
        }

        if(PlayerPrefs.GetInt("player")==1)
        {
            Ninja1Attack.SetActive(true);
            Ninja1Jump.SetActive(true);
            ninja1player.SetActive(true);
            Destroy(defplayer);
            Destroy(DefAttack);
            Destroy(DefJump);
            Destroy(ninja2player);
            Destroy(Ninja2Attack);
            Destroy(Ninja2Jump);
            // Destroy(defplayer);
            // Destroy(defplayer);
            // Destroy(defplayer);
        }

        if(PlayerPrefs.GetInt("player")==2)
        {
            Ninja2Attack.SetActive(true);
            Ninja2Jump.SetActive(true);
            ninja2player.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

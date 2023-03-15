using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
    public GameObject SelectedCharacter1, SelectedCharacter2, SelectedCharacter3, buybutton, selectbutton, buynowpanel, insupanel, sucpanel, des, ninja1, ninja2;
    public Text cointext, loreText, price, selectbuttontext;
    int charactercode;
    int delay = 0;

    void Start()
    {
        cointext.text = "" + PlayerPrefs.GetInt("Coins");
        if(PlayerPrefs.GetInt("player")==0)
        {
            SelectedCharacter3.SetActive(true);
            SelectedCharacter1.SetActive(false);
            SelectedCharacter2.SetActive(false);
            loreText.text = "Fujibayashi Nagato - Fujibayashi Nagato was a leader of the Iga ninjas during the 16th century, with his followers often serving the daimyo of Oomi domain in his battles against Oda Nobunaga.";
            price.text = "Obtained";
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            charactercode = 0;
            des.SetActive(true);
            selectbuttontext.text = "SELECTED";
        }

        if(PlayerPrefs.GetInt("player")==1)
        {
            SelectedCharacter1.SetActive(true);
            SelectedCharacter2.SetActive(false);
            SelectedCharacter3.SetActive(false);
            loreText.text = "Hattori Hanzo - Hattori Hanzos family was of the samurai class from Iga Domain, but he lived in Mikawa Domain and served as a ninja during Japans Sengoku period. Like Fujibayashi and Momchi, he commanded the Iga ninjas.";
            price.text = "Obtained";
            charactercode = 1;
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            selectbuttontext.text = "SELECTED";
        }

        if(PlayerPrefs.GetInt("player")==2)
        {
            SelectedCharacter2.SetActive(true);
            SelectedCharacter1.SetActive(false);
            SelectedCharacter3.SetActive(false);
            loreText.text = "Momochi Sandayu - Momochi Sandayu was the leader of the Iga ninjas in the second half of the 16th century, and most believe he died during Oda Nobunaga's invasion of Iga.";
            price.text = "Obtained";
            charactercode = 2;
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            selectbuttontext.text = "SELECTED";
        }
    }

    void Update()
    {
    
    }

    void updateshop()
    {
        if(PlayerPrefs.GetInt("Ninja2") == 1)
        {
            price.text = "Obtained";
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            cointext.text = "" + PlayerPrefs.GetInt("Coins");
        }

        if(PlayerPrefs.GetInt("Ninja1") == 1)
        {
            price.text = "Obtained";
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            cointext.text = "" + PlayerPrefs.GetInt("Coins");
        }
    }

    void updateselectbutton()
    {
        if(PlayerPrefs.GetInt("player")==1)
        {
            selectbuttontext.text = "SELECTED";
        }
        else
        {
            selectbuttontext.text = "SELECT";
        }
    }

    public void LoadMenu()
    {

            SceneManager.LoadScene("Assets/Scenes/Main Menu.unity");
    }

    IEnumerator Delay()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            delay +=1;
            LoadMenu();
        }
    }

    public void SelectCharacter1()
    {
        SelectedCharacter1.SetActive(true);
        SelectedCharacter2.SetActive(false);
        SelectedCharacter3.SetActive(false);
        loreText.text = "Hattori Hanzo - Hattori Hanzos family was of the samurai class from Iga Domain, but he lived in Mikawa Domain and served as a ninja during Japans Sengoku period. Like Fujibayashi and Momchi, he commanded the Iga ninjas.";
        if(PlayerPrefs.GetInt("Ninja1") == 0)
        {
            price.text = "32000";
            buybutton.SetActive(true);
            selectbutton.SetActive(false);
            charactercode = 1;
            des.SetActive(true);
        }
        if(PlayerPrefs.GetInt("Ninja1") == 1)
        {
            price.text = "Obtained";
            charactercode = 1;
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            if(PlayerPrefs.GetInt("player")==1)
            {
                selectbuttontext.text = "SELECTED";
            }
            else
            {
                selectbuttontext.text = "SELECT";
            }
        }
    }

    public void SelectCharacter2()
    {
        SelectedCharacter2.SetActive(true);
        SelectedCharacter1.SetActive(false);
        SelectedCharacter3.SetActive(false);
        loreText.text = "Momochi Sandayu - Momochi Sandayu was the leader of the Iga ninjas in the second half of the 16th century, and most believe he died during Oda Nobunaga's invasion of Iga.";
        if(PlayerPrefs.GetInt("Ninja2") == 0)
        {
            price.text = "24000";
            buybutton.SetActive(true);
            selectbutton.SetActive(false);
            charactercode = 2;
            des.SetActive(true);
        }
        if(PlayerPrefs.GetInt("Ninja2") == 1)
        {
            price.text = "Obtained";
            charactercode = 2;
            buybutton.SetActive(false);
            selectbutton.SetActive(true);
            des.SetActive(true);
            if(PlayerPrefs.GetInt("player")==2)
            {
                selectbuttontext.text = "SELECTED";
            }
            else
            {
                selectbuttontext.text = "SELECT";
            }
        }
    }

    public void SelectCharacter3()
    {
        SelectedCharacter3.SetActive(true);
        SelectedCharacter1.SetActive(false);
        SelectedCharacter2.SetActive(false);
        loreText.text = "Fujibayashi Nagato - Fujibayashi Nagato was a leader of the Iga ninjas during the 16th century, with his followers often serving the daimyo of Oomi domain in his battles against Oda Nobunaga.";
        price.text = "Obtained";
        buybutton.SetActive(false);
        selectbutton.SetActive(true);
        charactercode = 0;
        des.SetActive(true);
        if(PlayerPrefs.GetInt("player")==0)
            {
                selectbuttontext.text = "SELECTED";
            }
            else
            {
                selectbuttontext.text = "SELECT";
            }
    }

    public void Buy()
    {
        buynowpanel.SetActive(true);
    }

    public void buyno()
    {
        buynowpanel.SetActive(false);
    }

    public void buyyes()
    {
        if(PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
        {
            buynowpanel.SetActive(false);
            if(charactercode == 1)
            {
                sucpanel.SetActive(true);
                ninja1.SetActive(true);
                ninja2.SetActive(false);
                PlayerPrefs.SetInt("player", 1);
                PlayerPrefs.SetInt("Ninja1", 1);
                PlayerPrefs.SetInt("Coins",(int.Parse(cointext.text)  - int.Parse(price.text)));
                updateshop();
            }

            if(charactercode == 2)
            {
                sucpanel.SetActive(true);
                ninja2.SetActive(true);
                ninja1.SetActive(false);
                PlayerPrefs.SetInt("player", 2);
                PlayerPrefs.SetInt("Ninja2", 1);
                PlayerPrefs.SetInt("Coins",(int.Parse(cointext.text)  - int.Parse(price.text)));
                updateshop();
            }
        }
        else
        {
            buynowpanel.SetActive(false);
            insupanel.SetActive(true);
        }
    }

    public void insuokay()
    {
        insupanel.SetActive(false);
    }

    public void select()
    {
        if(charactercode == 1)
        {
            PlayerPrefs.SetInt("player", 1);
            selectbuttontext.text = "SELECTED";
        }

        if(charactercode == 2)
        {
            PlayerPrefs.SetInt("player", 2);
            selectbuttontext.text = "SELECTED";
        }
        if (charactercode == 0)
        {
            PlayerPrefs.SetInt("player", 0);
            selectbuttontext.text = "SELECTED";
        }
    }

    public void sucexit()
    {
        sucpanel.SetActive(false);
    }
}

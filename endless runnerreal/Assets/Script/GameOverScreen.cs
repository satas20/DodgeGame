using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            restartbutton();

        }

    }
    public void setup() 
    {
        scoretext.text = ("Your Score = " +Timer.score);
        gameObject.SetActive(true);
        Time.timeScale = 1 / 5;
    }
    public void mainmenubutton() 
    {
        SceneManager.LoadScene("MainMenu");
        
    }
   public void restartbutton()
    {
        
        SceneManager.LoadScene("GameRel");

    }
}

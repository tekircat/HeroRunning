using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SceneFader sceneFader;
    bool GameHasEnded = false;
    public GameObject gameover;
    public GameObject completeLevelUI;
    public GameObject DeBug;
    bool isOn = false;
    public GameObject Player;
   
   

    float timer;

    void Awake()
    {
       

        timer = 0.0f;

    }

    void Start()
    {
        gameover.SetActive(false);
        
    }

    void Update()
    {
        
    }


    public void EndGame ()

    {
        if (GameHasEnded == false)
        {
           
            GameHasEnded = true;
            gameover.SetActive(true);
            Time.timeScale = 0.5f;
            Player.SetActive(false);
        }
    }

    public void Restart()
        {
            AudioListener.pause = false;
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
            gameover.SetActive(false);

        }

    public void Continue()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        gameover.SetActive(false);
        GameHasEnded = false;
        Player.SetActive(true);
    
    }

    public void WinLevel()
    {
        if (GameHasEnded == false)
        {
       
        GameHasEnded = true;
        completeLevelUI.SetActive(true);
            
     

        }
    }

    public void MainMenu()
    {
            AudioListener.pause = false;
        sceneFader.FadeTo("MainMenu");  
        Time.timeScale = 1;
        }

    public void DeBugOpClo()
    {
        if(isOn==false)
        {

        DeBug.SetActive(true);
            isOn = true;

        }
        else
        {

            DeBug.SetActive(false);
            isOn = false;

        }
        
    }

    
}

 









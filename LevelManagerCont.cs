using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerCont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //It will return level value, if player is playing game first time default value is return 0
        int level = PlayerPrefs.GetInt("Level", 0);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void LevelComplete()
    {
        //It will return current level
        int currentLevel = PlayerPrefs.GetInt("Level", 0);
        // Now we increase one level and store new level
        currentLevel++;
        PlayerPrefs.SetInt("Level", currentLevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels;
    private int CurrentLevel;
    public static LevelManager instance;

    private void Awake() {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        LoadNextLevel();
    }


    public void HideAllLevels()
    {
        foreach (var level in Levels)
        {
            level.SetActive(false);
        }
    }

    public void LoadNextLevel()
    {
        if(CurrentLevel >= Levels.Length)
        {
            return;
        }
        HideAllLevels();
        Levels[CurrentLevel].SetActive(true);
        CurrentLevel++;
    }
}

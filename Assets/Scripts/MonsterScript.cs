using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterScript : MonoBehaviour
{
    AudioManager manager;
    public GameObject[] enemies;
    public int no_of_monster;
    public static int monster_count;
    public static ScoreBoard instance;
    public void Awake()
    {
        manager = FindObjectOfType<AudioManager>();
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        no_of_monster = enemies.Length;
        monster_count = 0;
        instance = ScoreBoard.GetInstance();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            monster_count += 1;
            ScoreBoard.GetInstance().AddScore(10);
            ScoreBoard.GetInstance().AddKills(1);


            Destroy(gameObject);
            

            if(monster_count == no_of_monster){
                Debug.Log("Monters" + monster_count);
                // SceneManager.LoadScene("Level_1");
                LevelManager.instance.LoadNextLevel();
            }
            // manager.PlayMySound("hitMonster");
        }
    }
    
}

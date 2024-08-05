using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int player_score;
    private float move_speed = 4f;
    public Text score_text;
    public GameObject game_over_screen;
    public PipeSpawner pipe_spawner;

    void Start()
    {
        pipe_spawner = GameObject.FindGameObjectWithTag("pipe_spawner").GetComponent<PipeSpawner>();
    }
    //--------------SCORE SYSTEM-----------
    //Add score to the top left counter
    public void addScore(int score_to_add)
    {
        player_score += score_to_add;
        score_text.text = player_score.ToString();
    }

    //Get player score
    public int getScore()
    {
        return player_score;
    }
    
    //-------------GAME OVER-----------------------
    //Show game over screen
    public void gameOver()
    {
        game_over_screen.SetActive(true);
    }


    //Restart the game reloading the scene
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //----------PIPES SYSTEM-----------
    public void addSpeed(float value)
    {
        move_speed += value;
        pipe_spawner.fastSpawnRate(value/4.5f);
    }

    public float getMoveSpeed()
    {
        return move_speed;
    }

}

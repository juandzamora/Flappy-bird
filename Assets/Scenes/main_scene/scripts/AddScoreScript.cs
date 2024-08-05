using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AddScoreScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }

        if(logic.getScore() <= 50)
        {
            if(logic.getScore() % 5 == 0)
            {
                logic.addSpeed(0.5f);
            }
        }
    }
}

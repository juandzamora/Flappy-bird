using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdActions : MonoBehaviour
{
    public float jump_power;
    public bool bird_alive = true;
    public LogicScript logic;
    public Rigidbody2D bird_physics;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0)) && bird_alive)
            bird_physics.velocity = Vector2.up * jump_power;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        bird_alive = false;
    }
}

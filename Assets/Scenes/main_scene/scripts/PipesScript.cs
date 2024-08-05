using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesScript : MonoBehaviour
{
    public float dead_zone = -10;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * logic.getMoveSpeed()) * Time.deltaTime;

        if(transform.position.x < dead_zone)
            Destroy(gameObject);
    }
}

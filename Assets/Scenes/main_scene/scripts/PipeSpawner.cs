using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipes_prefab;
    public float spawn_rate = 2;
    private float timer = 0;

    public float height_offset = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawn_rate)
            timer += Time.deltaTime;
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;

        Instantiate(pipes_prefab, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), 0), transform.rotation);
    }

    public void fastSpawnRate(float value)
    {
        spawn_rate -= value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawn_script : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate;
    private float timer = 0;
    public float height_offset = 0;

    void Start()
    {
        Spawn_pipe();
    }

    void Update()
    {
        if (timer < spawn_rate) {
            timer += Time.deltaTime;
        } else {
            Spawn_pipe();
            timer = 0;
        }
    }

    void Spawn_pipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;

        Instantiate(pipe,
            new Vector3(transform.position.x, Random.Range(lowest_point, highest_point)),
            transform.rotation
        );
    }
}

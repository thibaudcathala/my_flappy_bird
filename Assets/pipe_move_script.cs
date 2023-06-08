using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move_script : MonoBehaviour
{
    public float move_speed = 5;
    private float dead_zone = -35;

    void Start()
    {
        return;
    }

    void Update()
    {
        if (transform.position.x <= dead_zone)
        {
            Destroy(gameObject);
        }
        transform.position += Vector3.left * move_speed * Time.deltaTime;
    }
}

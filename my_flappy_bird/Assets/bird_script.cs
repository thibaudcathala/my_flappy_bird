using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D my_rigidbody;
    public float fly_multiplicator;
    public ui_manager manager;
    private bool is_alive = true;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("logic").GetComponent<ui_manager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && is_alive) {
            my_rigidbody.velocity = Vector2.up * fly_multiplicator;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        is_alive = false;
        manager.game_over();
    }
}

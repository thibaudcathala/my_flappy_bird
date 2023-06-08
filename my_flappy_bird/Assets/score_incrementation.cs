using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Timeline;

public class score_incrementation : MonoBehaviour
{
    public ui_manager manager;
    private int player_layer = 3;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("logic").GetComponent<ui_manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == player_layer) {
            manager.add_score(1);
        }
    }
}

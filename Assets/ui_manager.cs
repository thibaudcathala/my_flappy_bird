using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui_manager : MonoBehaviour
{
    public int player_score;
    public Text score_text;
    public GameObject game_over_screen;

    public void add_score(int score_to_add)
    {
        player_score += score_to_add;
        score_text.text = player_score.ToString();
    }

    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void game_over()
    {
        game_over_screen.SetActive(true);
    }
}

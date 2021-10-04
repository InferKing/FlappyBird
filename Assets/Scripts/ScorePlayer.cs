using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlayer : MonoBehaviour
{
    private int _score;
    public Text scoreText;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        scoreText.text = _score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            _score++;
        }
    }
}

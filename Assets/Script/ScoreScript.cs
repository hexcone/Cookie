using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public int score = 0;
    public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    void MinusScore()
    {
        score--;
        scoreText.text = "Score: " + score;
    }
}

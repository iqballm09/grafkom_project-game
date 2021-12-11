using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public Text finalScoreText;
    public Text highScoreGOText;
    public Transform ojek;

    int score = 0;
    public int highscore = 0;
    int val = (int) 12.76;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", score);
        scoreText.text = "Your Score : " + score.ToString();
        finalScoreText.text = scoreText.text;
        highScoreText.text = "High Score : " + highscore.ToString();
        highScoreGOText.text = "High Score : " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = (int) ojek.position.y + val;
        scoreText.text = "Your Score : " + score.ToString();
        finalScoreText.text = scoreText.text;
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 점수를 카운트해서 UI에 표현하고싶다.
public class ScoreManager : MonoBehaviour
{
    // 싱글톤 패턴
    public static ScoreManager instance = null;

    private void Awake()
    {
        ScoreManager.instance = this;
    }

    private int score;
    public Text textScore;
    // property
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            textScore.text = "Score : " + score;

            // 만약 score가 highScore보다 크다면
            if (score > highScore)
            {
                // HighScore에 score를 넣고
                HighScore = score;
                // 저장하고싶다.
                PlayerPrefs.SetInt("HighScore", HighScore);
            }
        }
    }

    private int highScore;
    public Text textHighScore;
    // property
    public int HighScore
    {
        get { return highScore; }
        set
        {
            highScore = value;
            textHighScore.text = "HighScore : " + highScore;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // 점수를 0점으로 하고싶다.
        Score = 0;
        // 최고점수를 가져오고싶다.
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

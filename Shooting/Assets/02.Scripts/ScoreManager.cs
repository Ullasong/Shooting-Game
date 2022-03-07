using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ������ ī��Ʈ�ؼ� UI�� ǥ���ϰ�ʹ�.
public class ScoreManager : MonoBehaviour
{
    // �̱��� ����
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

            // ���� score�� highScore���� ũ�ٸ�
            if (score > highScore)
            {
                // HighScore�� score�� �ְ�
                HighScore = score;
                // �����ϰ�ʹ�.
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
        // ������ 0������ �ϰ�ʹ�.
        Score = 0;
        // �ְ������� ��������ʹ�.
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

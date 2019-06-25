using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text timeText;

    private int _score;
    private float _time = 60;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        AddScore(0);
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("score", _score);
        SceneManager.LoadScene("GameOver");
    }

    public void AddScore(int value)
    {
        _score += value;

        scoreText.text = _score.ToString();
    }

    void Update()
    {
        _time -= Time.deltaTime;
        int showTime = (int) (_time);
        timeText.text = showTime.ToString();
        if (_time < 0)
        {
            GameOver();
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    public void OnStartClick()
    {
        SceneManager.LoadScene("Game");
    }

    private void OnEnable()
    {
        int saveScore = PlayerPrefs.GetInt("score");
        if (saveScore != 0)
        {
            scoreText.text = saveScore.ToString();
        }
    }
}
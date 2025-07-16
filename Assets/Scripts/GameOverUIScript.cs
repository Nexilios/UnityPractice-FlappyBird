using TMPro;
using UnityEngine;

public class GameOverUIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private void Start()
    {
        if (!scoreText) return;
        
        scoreText.text = "HI SCORE: " + PlayerPrefs.GetInt("HighScore");
    }
}

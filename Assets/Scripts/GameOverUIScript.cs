using TMPro;
using UnityEngine;

public class GameOverUIScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private void Start()
    {
        if (!scoreText) return;
        
        scoreText.text = "Hi Score: " + PlayerPrefs.GetInt("HighScore");
    }
}

using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    
    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }
}

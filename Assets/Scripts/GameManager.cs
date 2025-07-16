using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject scoreUI;
    public AudioSource scoreAudio;
    
    [SerializeField]
    private TextMeshProUGUI scoreText;
    
    private void Start()
    {
        score = 0;
        gameOverScreen.SetActive(false);

        if (!scoreUI) return;
        
        scoreUI.SetActive(true);
        scoreText = scoreUI.GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString();
    }
    
    public void AddScore(int scoreToAdd)
    {
        if (isGameOver) return;
        
        if (scoreAudio) scoreAudio.Play();
        
        score += scoreToAdd;
        if (scoreText) scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        isGameOver = true;
        
        if (score > PlayerPrefs.GetInt("HighScore")) PlayerPrefs.SetInt("HighScore", score);
        
        scoreUI.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}

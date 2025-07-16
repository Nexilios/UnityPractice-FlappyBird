using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    
    private void Start()
    {
        if (!highScoreText) return;
        
        highScoreText.text = "HI SCORE: " + PlayerPrefs.GetInt("HighScore");
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

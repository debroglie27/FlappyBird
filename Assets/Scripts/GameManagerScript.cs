using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverPanel;
    public BirdMovement birdMovement;
    public AudioSource dingSFX;
    public AudioSource gameOverSFX;

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        if(birdMovement.birdIsAlive)
        {
            dingSFX.Play();
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        if(birdMovement.birdIsAlive)
        {
            gameOverSFX.Play();
            gameOverPanel.SetActive(true);
        }
    }
}

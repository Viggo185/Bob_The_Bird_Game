using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
   public int PlayerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   
   

   private bool gameStarted = false;

    private void Start()
    {
        PlayerScore = 0;
        scoreText.text = PlayerScore.ToString();
        

       

        
    }

   [ContextMenu("Increse Score")]


   public void addScore(int scoreToAdd)
    {
        PlayerScore = PlayerScore + scoreToAdd;
        scoreText.text = PlayerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    



}

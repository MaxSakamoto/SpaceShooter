
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void restartGame()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex);
        
    }

    // Update is called once per frame
    public void exitGame()
    {
        Application.Quit();
    }
}

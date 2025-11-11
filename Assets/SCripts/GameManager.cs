using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public function to restart game
    public void RestartGame()
    {   
        //restarts the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //function to send user to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
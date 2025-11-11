using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    //score text variable setup
    public TextMeshProUGUI scoreText;

    // public function to setup the background
    public void setup(int score)
    {
        //sets the background to true
        gameObject.SetActive(true);
        //sets the score text to the current score
        scoreText.text = "Your Score: " + score.ToString();
    }


}

  
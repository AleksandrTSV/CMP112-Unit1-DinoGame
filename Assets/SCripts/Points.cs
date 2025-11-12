using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Points : MonoBehaviour
{
    private int score = 0;
    public GameOver GameOver;
    public TextMeshProUGUI scoreText;
    public GameObject player;

    private void Update()
    {
        if (player.activeInHierarchy == false) 
        {
            GameOver.setup(score);
        }
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cactus"))
        {
            score += 1;
            setScoreText();
        }

    }
}

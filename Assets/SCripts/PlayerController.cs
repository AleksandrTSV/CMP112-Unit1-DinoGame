using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using System.Collections;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 450f;
    InputSystem_Actions inputActions;
    //score variable to count the score
    private int score = 0;
    //public variable to display score on the UI
    public TextMeshProUGUI scoreText;
    //reference to GameOver script
    public GameOver GameOver;
    //variables for audio 
    private AudioSource source;
    public AudioClip jumpSound;
    public static bool alive = true;

    
    private void Awake()
    {
        inputActions = new InputSystem_Actions();
        //starting the audio source
        source = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //setting score to 0 at the start of the game
        score = 0;
        //updating the score text on the UI
        setScoreText();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        inputActions.Player.Jump.performed += _ => OnJump();
    }

    void OnJump()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.6f))
        {
            //play jump sound effect
            source.PlayOneShot(jumpSound, 1.0f);
            rb.AddForce(0, jumpForce * Time.fixedDeltaTime, 0, ForceMode.VelocityChange);
            
        }

    }
    // function to set the score text on the UI
    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    //on trigger enter method to check for collisions with Cactus and PointBarrier
    void OnTriggerEnter(Collider other)
    {
        //checking if the player collides with the Cactus and deactivating the player game object
        if (other.gameObject.CompareTag("Cactus"))
        {
            Time.timeScale = 0;
            gameObject.SetActive(false);
            
            //calling the setup method from GameOver script and passing the score
            //GameOver.setup(score);
        }
    }
}

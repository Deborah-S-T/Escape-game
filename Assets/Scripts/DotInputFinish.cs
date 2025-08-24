using UnityEngine;
using TMPro; // Make sure to include the TextMeshPro namespace

public class DotInputFinish : MonoBehaviour
{

    public GameObject inputText; // Reference to the TextMeshProUGUI component to show input
    public GameObject ground;
    public GameObject win;
    public GameObject youWon;

    public GameObject bottomGround;

    private int counter = 0;
    private int counterEnd = 300;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        win.SetActive(false);
        youWon.SetActive(false);
        bottomGround.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (! ground.activeSelf)
        {
            if (counter == counterEnd)
            {
                ground.SetActive(true);
                bottomGround.SetActive(true);
            }
            else
            {
                counter++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player (or another specified object)
        if (other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
        {
            if (!inputText.gameObject.activeSelf)
            {
                // Show the input text
                inputText.gameObject.SetActive(true);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object entering the trigger is the player (or another specified object)
        if (other.CompareTag("Player")) // Make sure the player GameObject has the tag "Player"
        {
            if (inputText.gameObject.activeSelf)
            {
                // Show the input text
                inputText.gameObject.SetActive(false);
            }

        }
    }
   
   public void OnEndText(string input)
    {
        // This method can be called to handle the end of text input
        if (input == "367136")
        {
            Destroy(inputText); // Destroy the inputText GameObject
            win.SetActive(true);
            ground.SetActive(false); // Deactivate the ground GameObject
            youWon.SetActive(true);
        }
    }
}

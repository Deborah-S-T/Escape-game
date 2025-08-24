using UnityEngine;
using TMPro; // Make sure to include the TextMeshPro namespace

public class BoxInputShower : MonoBehaviour
{

    public GameObject inputText; // Reference to the TextMeshProUGUI component to show input

    public GameObject ramp;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (inputText != null)
        {
            inputText.gameObject.SetActive(false); // Hide the input text at the start
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if (input == "aebfdc")
        {
            ramp.gameObject.SetActive(true); // Activate the ramp GameObject when the input text matches "aebfdc";
            Destroy(gameObject); // Destroy this GameObject after the input is matched
            Destroy(inputText); // Destroy the inputText GameObject
        }
    }
}

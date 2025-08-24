using UnityEngine;

public class BrailleButton : MonoBehaviour
{

    public GameObject braillePanel;
    private bool isPressed = false;
    public GameObject cylinder;
    private Vector3 buttonpresser = new Vector3(0, 0.3f, 0);
    public AudioClip buttonSound;
    public GameObject cheatsheet;

    public GameObject hidebraille;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        braillePanel.SetActive(false);
        cheatsheet.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            braillePanel.SetActive(true);
            cheatsheet.SetActive(true);
            hidebraille.SetActive(false);
        }
        else
        {
            braillePanel.SetActive(false);
            cheatsheet.SetActive(false);
            hidebraille.SetActive(true);
        }
    }

    void OnMouseDown()
    {
        if (!isPressed)
        {
            isPressed = true;
            cylinder.transform.position -= buttonpresser; // Move the cylinder down
            cylinder.transform.localScale -= buttonpresser;
            gameObject.transform.position -= buttonpresser; // Move the button down
            //AudioSource.PlayClipAtPoint(buttonSound, transform.position);
        }
        else
        {
            isPressed = false;
            cylinder.transform.position += buttonpresser; // Move the cylinder up
            cylinder.transform.localScale += buttonpresser;
            gameObject.transform.position += buttonpresser; // Move the button down
            //AudioSource.PlayClipAtPoint(buttonSound, transform.position);
        }
    }
}

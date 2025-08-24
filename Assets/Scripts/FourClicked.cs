using UnityEngine;

public class FourClicked : MonoBehaviour
{

    public GameObject start;
    public GameObject next1;

    private Vector3 initialPositionStart;
    private Vector3 initialPosition4;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        next1.SetActive(false);

        initialPositionStart = start.transform.position;
        initialPosition4 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (start.transform.position == initialPositionStart)
        {
            transform.position = initialPositionStart;
            next1.transform.position = initialPosition4;
            start.SetActive(false);
            next1.SetActive(true);
        }
        
    }
}

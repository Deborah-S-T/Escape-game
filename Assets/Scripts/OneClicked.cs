using UnityEngine;

public class OneClicked : MonoBehaviour
{

    public GameObject start;
    public GameObject four;
    public GameObject next2;
    public GameObject next1;

    private Vector3 initialPositionStart;
    private Vector3 initialPosition4;
    private Vector3 initialPosition1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        next2.SetActive(false);

        initialPositionStart = start.transform.position;
        initialPosition4 = four.transform.position;
        initialPosition1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (four.transform.position == initialPositionStart)
        {
            transform.position = initialPosition4;
            next1.SetActive(false);
            next2.transform.position = initialPosition1;
            next2.SetActive(true);

        }
    }
}

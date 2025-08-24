using UnityEngine;

public class ThreeClicked : MonoBehaviour
{

    public GameObject one;
    public GameObject four;
    public GameObject next3;
    public GameObject next2;

    private Vector3 initialPosition1;
    private Vector3 initialPosition4;
    private Vector3 initialPosition3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        next3.SetActive(false);

        initialPosition1 = one.transform.position;
        initialPosition4 = four.transform.position;
        initialPosition3 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (one.transform.position == initialPosition4)
        {
            transform.position = initialPosition1;
            next2.SetActive(false);
            next3.transform.position = initialPosition3;
            next3.SetActive(true);
        }
    }
}

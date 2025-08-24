using UnityEngine;

public class TwoClicked : MonoBehaviour
{
    public GameObject answer;
    public GameObject three;
    public GameObject one;

    public GameObject four;
    public GameObject next3;
    public GameObject basee;

    private Vector3 initialPosition1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        answer.SetActive(false);

        initialPosition1 = one.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (three.transform.position == initialPosition1)
        {
            one.SetActive(false);
            gameObject.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);

            next3.SetActive(false);
            basee.SetActive(false);

            answer.SetActive(true);
        }
    }
}

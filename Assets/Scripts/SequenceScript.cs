using UnityEngine;

public class SequenceScript : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;



    private Vector3 initialPosition1;
    private Vector3 initialPosition2;
    private Vector3 initialPosition3;
    private Vector3 initialPosition4;

    private float above = 0.0003f;

    private int counter = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        initialPosition1 = one.transform.position;
        initialPosition1.x += above;
        initialPosition2 = two.transform.position;
        initialPosition2.x += above;
        initialPosition3 = three.transform.position;
        initialPosition3.x += above;
        initialPosition4 = four.transform.position;
        initialPosition4.x += above;


        transform.position = initialPosition1;

    }

    // Update is called once per frame
    void Update()
    {
        initialPosition1 = one.transform.position;
        initialPosition1.x += above;
        initialPosition2 = two.transform.position;
        initialPosition2.x += above;
        initialPosition3 = three.transform.position;
        initialPosition3.x += above;
        initialPosition4 = four.transform.position;
        initialPosition4.x += above;

        if (counter == 100)
        {
            //Debug.Log("Current position: " + transform.position + "1:" + initialPosition1 + "2:" + initialPosition2 + "3:" + initialPosition3 + "4:" + initialPosition4);

            counter = 0; // Reset the counter
            float threshold = 0.1f; // Define a threshold for position comparison

            if (Vector3.Distance(transform.position, initialPosition1) < threshold)
            {
                transform.position = initialPosition2;
            }
            else if (Vector3.Distance(transform.position, initialPosition2) < threshold)
            {
                transform.position = initialPosition3;
            }
            else if (Vector3.Distance(transform.position, initialPosition3) < threshold)
            {
                transform.position = initialPosition4;
            }
            else if (Vector3.Distance(transform.position, initialPosition4) < threshold)
            {
                transform.position = initialPosition1;
            }
        }
        else
        {
            counter++;
        }

    }

}

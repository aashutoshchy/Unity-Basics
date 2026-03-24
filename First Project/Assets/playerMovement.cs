using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 5, 0);
        }

        // For Left and Right
        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(-5, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(5, 0, 0);
        }

        // For Up and Down
        if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 5);
        }

        if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, -5);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Speed of character movement and height of the jump. Set these values in the inspector.
    public float speed;

    // Camera rotate
    public float camSpeedH = 5.0f;
    private float rot = 0.0f;

    //public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If 'W' go forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
            print("forward: " + transform.forward);
        }
        // ASD etc
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

        // Rotate camera toward cursor
        Vector2 cameraPos = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mousePos = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //float angle = AngleBetweenTwoPoints(cameraPos, mousePos);
        //rb.transform.rotation = Quaternion.Euler(new Vector3(0f, -angle, 0f));
        rot += camSpeedH * Input.GetAxis("Mouse X");
        //transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);
        transform.rotation = Quaternion.Euler(new Vector3(0f, rot, 0f));

    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}

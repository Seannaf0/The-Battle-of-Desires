using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EurydiceMovement : MonoBehaviour
{
    public Vector3 upDirection;
    public Vector3 downDirection;
    public Vector3 leftDirection;
    public Vector3 rightDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position += leftDirection;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += rightDirection;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().position += upDirection;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Transform>().position += downDirection;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;

        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upDirection;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downDirection;
        }
    }
}

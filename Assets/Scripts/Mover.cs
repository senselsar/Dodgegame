using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float moveSpeed = 10f;
    //[SerializeField] float xValue = 0f;
    //[SerializeField] float yValue = 0.1f;
    //[SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }   

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Don't hit the wall");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);

    }
}

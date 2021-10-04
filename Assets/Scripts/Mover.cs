using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float _moveSpeed;

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

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0f, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome!");
        Debug.Log("Move the player with the WSAD or the arrow keys.");
        Debug.Log("Do not hit any obstacles!");
    }

}

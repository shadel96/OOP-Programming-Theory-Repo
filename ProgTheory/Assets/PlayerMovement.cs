using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    public float playerSpeed = 5f;


    // Update is called once per frame
    void Update()
    {
        MovePlayer();


    }

    void MovePlayer()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 destination = new Vector3(horizontal, vertical, 0);
        destination = destination.normalized * playerSpeed * Time.deltaTime;

        transform.position += destination;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public GameObject destinationObj;
    private Vector3 destination;
    private float repeatTiming;
    private float animalSpeed;


    void Start()
    {
        SetParams();
        InvokeRepeating("MoveToDestination", 1f, repeatTiming);
    }

    public virtual void SetParams()
    {
        repeatTiming = 4f;
        animalSpeed = 4f;
    }

    public virtual void MoveToDestination()
    {
        destination = destinationObj.transform.position;
    }

    private void Update()
    {
        GoTo(destination)
    }

    public void GoTo(Vector3 position)
    {
        transform.position = Vector3.MoveTowards(transform.position, position, animalSpeed * Time.deltaTime);

    }
}

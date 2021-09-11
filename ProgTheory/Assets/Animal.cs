using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public GameObject destinationObj;
    public Vector3 destination;
    public float repeatTiming;
    public float animalSpeed;


    void Start()
    {
        SetParams();
        SetDestination();
        MoveToDestination(repeatTiming);
    }

    public virtual void SetParams()
    {
        repeatTiming = 0f;
        animalSpeed = 0f;
    }

    public void MoveToDestination(float timing)
    {
        InvokeRepeating("SetDestination", timing, repeatTiming);
        
    }

    public virtual void SetDestination()
    {
        destination = destinationObj.transform.position;
    }

    private void Update()
    {
        GoTo(destination);
    }

    public void GoTo(Vector3 position)
    {
        transform.position = Vector3.MoveTowards(transform.position, position, animalSpeed * Time.deltaTime);

    }
}

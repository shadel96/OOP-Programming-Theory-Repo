using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Mouse : Animal
{

    public override void SetParams()
    {
        repeatTiming = 7.5f;
        animalSpeed = 9f;
    }
        

    //POLYMORPHISM
    public override void SetDestination()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);
        destination = new Vector3(x, y, 0f);
    }
}

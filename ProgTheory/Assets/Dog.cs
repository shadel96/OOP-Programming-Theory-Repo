using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE

public class Dog : Animal
{


    public override void SetParams()
    {
        repeatTiming = 3f;
        animalSpeed = 4f;
    }
}

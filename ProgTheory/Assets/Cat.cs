using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public override void SetParams()
    {
        repeatTiming = 10f;
        animalSpeed = 6f;
    }
}

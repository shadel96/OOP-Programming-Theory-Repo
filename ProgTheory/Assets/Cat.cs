using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE

public class Cat : Animal

{
    public override void SetParams()
    {
        repeatTiming = 10f;
        animalSpeed = 6f;
    }
}

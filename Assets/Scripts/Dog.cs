using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        typeOfAnimal = "Dog";
        animalName = "Yerik";
    }
    public override void Talk()
    {
        text.text = $"I am a {typeOfAnimal} and my name is {animalName} HAFF";
    }

    public override void Jump()
    {
        base.Jump();
    }
}

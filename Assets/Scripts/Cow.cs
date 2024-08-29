using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        typeOfAnimal = "Cow";
        animalName = "Eva";
    }
    public override void Talk()
    {
        text.text = $"I am a {typeOfAnimal} and my name is {animalName} MOOOOO";
    }

    public override void Jump()
    {
        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }
}

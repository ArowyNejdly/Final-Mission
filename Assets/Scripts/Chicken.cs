using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        typeOfAnimal = "Chicken";
        animalName = "Bob";
    }
    public override void Talk()
    {
        text.text = $"I am a {typeOfAnimal} and my name is {animalName} KOKODAA";
    }

    public override void Jump()
    {
        rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}

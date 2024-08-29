using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string typeOfAnimal;
    // ENCAPSULATION
    protected string animalName;
    public string AnimalName
    {
        get { return animalName; }
        set
        { 
            if(value.Length < 8 && value.Length > 0)
            {
                animalName = value;
            }
        }
    }

    protected Rigidbody rb;

    [SerializeField] protected TextMeshProUGUI text;

    // POLYMORPHISM
    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    // ABSTRACTION
    public abstract void Talk();
    
}

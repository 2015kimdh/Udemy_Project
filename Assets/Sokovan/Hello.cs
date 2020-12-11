using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{

    void Start(){
        Animal jack = new Animal();
        jack.name = "Tool";
        jack.sound = "Bark";
        jack.weight = 5.0f;

        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(jack.weight);

    }

   

}

public class Animal{
    
    public string name;
    public string sound;
    public float weight;

}
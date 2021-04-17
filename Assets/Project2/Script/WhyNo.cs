using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhyNo : MonoBehaviour
{
    void Start()
    {
        Cat nate = new Cat();
        nate.name = "Nate";
        nate.weight = 1.5f;
        nate.age = 3;

        Dog jack = new Dog();
        jack.name = "Jack";
        jack.weight = 5f;
        jack.age = 2;

        /////

        nate.stealth();
        nate.Print();

        jack.hunt();
        jack.Print();

        Animals[] animals = new Animals[2];
        animals[0] = nate;
        animals[1] = jack;

        for(int i = 0; i < animals.Length; i++){
            animals[i].Print();
        }
    }
}
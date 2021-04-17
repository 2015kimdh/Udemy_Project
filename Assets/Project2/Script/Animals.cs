using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals: MonoBehaviour
{
    public string name;
    public float age;
    public float weight;

    public void Print(){
        Debug.Log(name + "| 몸무게: " + weight + "| 나이: " + age);
    }

    protected float GetSpeed(){
        return CalcSpeed();
    }

    private float CalcSpeed(){
        return 100f/(weight*age);
    }
}

public class Dog: Animals{
    public void hunt(){
        float speed = GetSpeed();
        Debug.Log(speed + " 의 속도로 달려가서 사냥");
        weight += 10f;
    }
}

public class Cat: Animals{
    public void stealth(){
        Debug.Log("숨음");
    }
}

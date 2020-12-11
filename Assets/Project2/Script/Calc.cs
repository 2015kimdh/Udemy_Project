using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calc : MonoBehaviour
{

    public int Sum(int a, int b){
        return a+b;
    }
    public int Sum(int a, int b, int c){
        return a+b+c;
    }
    public int Sum(int a, int b, int c, int d){
        return a+b+c+d;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Sum(1,2,3,4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

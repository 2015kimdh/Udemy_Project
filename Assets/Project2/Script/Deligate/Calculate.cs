using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    delegate float Calculator(float a, float b);
    Calculator onCalculate;

    void Start(){
        onCalculate = Sum;
        onCalculate = onCalculate + Subtract;

    }
   public float Sum(float a, float b){
       Debug.Log(a+b);
       return a+b;
   }
   public float Subtract(float a, float b){
       Debug.Log(a-b);
       return a-b;
   }
   public float Multiply(float a, float b){
       Debug.Log(a*b);
       return a*b;
   }

   void Update() {
       if(Input.GetKeyDown(KeyCode.Space)){
           Debug.Log("결과값 : " +onCalculate(1, 10));
       }
   }
}

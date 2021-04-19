using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Container<string> container = new Container<string>();
        container.messeges = new string[3];

        container.messeges[0] = "Hello";
        container.messeges[1] = "World";
        container.messeges[2] = "Generic";
        for(int i = 0; i < container.messeges.Length; i++){
            Debug.Log(container.messeges[i]);
        }
    }

    public void Print<T>(T inputMessage){
        Debug.Log(inputMessage);
    }

    public class Container<T>{
        public T[] messeges;
    }
}

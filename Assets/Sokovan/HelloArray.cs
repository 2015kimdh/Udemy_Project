using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called before the first frame update
public Transform g;
        

    void Start(){
        gon jack = new gon();
        jack.name = "Tl";
        jack.sound = "Bk";
        jack.weight = 10.0f;

        Debug.Log(jack.name);
        Debug.Log(jack.sound);
        Debug.Log(jack.weight);
        g.Translate(0, 10,0 );
    }

   void Update() {
        g.Translate(0, -0.1f,0 );
    }
   

}

public class gon{
    
    public string name;
    public string sound;
    public float weight;

}

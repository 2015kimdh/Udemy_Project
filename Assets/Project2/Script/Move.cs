using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 move = new Vector3(-1, -1, -1);
    Vector3 targetPosition = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.Space)){
            Moving();
        }
    }

    void Moving(){
        transform.Translate(move*Time.deltaTime);
    }
}

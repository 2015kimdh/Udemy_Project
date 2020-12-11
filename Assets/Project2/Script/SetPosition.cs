using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(new Vector3(30, 30, 30));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

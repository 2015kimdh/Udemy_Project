using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRotator : BaseRotater
{
    // Start is called before the first frame update
    protected override void Rotate()
    {
        transform.Rotate(speed*Time.deltaTime,0,0);
    }

    // Update is called once per frame
}

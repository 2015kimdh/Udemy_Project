using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotater : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 60f;

    protected virtual void Rotate(){
        transform.Rotate(speed * Time.deltaTime, 0,0);
    }

    private void Update() {
        Rotate();
    }
}

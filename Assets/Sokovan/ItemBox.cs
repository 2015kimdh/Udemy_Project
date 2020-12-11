using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isCollide = false;
    private Renderer myRenderer;

    public Color touchColor = Color.red;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "EndPoint"){
            myRenderer.material.color = touchColor;
            isCollide = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.tag == "EndPoint"){
            myRenderer.material.color = originalColor;
            isCollide = false;
        }
    }

    void OnTriggerStay(Collider other) {
        if(other.tag == "EndPoint"){
            myRenderer.material.color = touchColor;
            isCollide = true;
        }
    }

}

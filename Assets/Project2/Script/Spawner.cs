using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody target;
    public Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody instance = Instantiate(target,spawnPosition.position, spawnPosition.rotation);

        instance.AddForce(0, 1000, 0);
        Debug.Log(instance.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

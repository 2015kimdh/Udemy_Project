using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonster : MonoBehaviour
{
    public BaseMonster[] monsters;
    // Start is called before the first frame update
    void Start()
    {
        monsters = FindObjectsOfType<BaseMonster>();
        for(int i = 0; i < monsters.Length; i++){
            Debug.Log(monsters[i].gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

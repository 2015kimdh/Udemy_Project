using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEvent : MonoBehaviour
{
    public delegate void Boost(CharacterEvent target);
    public Boost playerBoost;
    // Start is called before the first frame update
    public string playerName = "Yea";
    public float hp = 1000;
    public float defense = 50;
    public float damage = 30;

    void Start(){
        playerBoost(this);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            playerBoost(this);
        }
    }
}

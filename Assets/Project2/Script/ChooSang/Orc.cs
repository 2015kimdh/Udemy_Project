using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : BaseMonster
{
    // Start is called before the first frame update
    void Awake() {
        damage = 10f;
    }
    public override void Attack(){
        Debug.Log("광역공격" + damage);
    }
}

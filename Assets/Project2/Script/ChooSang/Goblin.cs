using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseMonster
{
    // Start is called before the first frame update
    public override void Attack()
    {
        Debug.Log("캐릭터를 공격했다." + damage);
    }

    // Update is called once per frame
}

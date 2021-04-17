using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerHp : MonoBehaviour
{
    public enum towerStatus{
        alive,
        death
    }
    public towerStatus status;
    public float hp;
    void TakeDamage(float damage){
        if(hp > 0 && status == towerStatus.alive){
            hp -= damage;
            if(hp <= 0){
                status = towerStatus.death;
            }
        }
    }
    // Update is called once per frame
}

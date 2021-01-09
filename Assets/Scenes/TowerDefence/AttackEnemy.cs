using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
    public GameMaker ingameManagerInstance;
    public Tower instance;
    public enum attackType{
        ad,
        ap,
        heal
    }
    public attackType whatTypeAttack;

    public float CalculateDamage(){
        int target = instance.GetTargetID();
        float damage = 0;
        Tower enemy;
        for(int i = 0; i < ingameManagerInstance.towerList.Count; i++){
            if(ingameManagerInstance.towerList[i].inGameID == target)
            {
                enemy = Instantiate(ingameManagerInstance.towerList[i]);
                damage = instance.attackPoint - enemy.armorPoint;
                if(damage <= 0)
                    return 1;
                return damage;
            }
        }
        return damage;
    }


    void Awake() {
        if(instance == null){
            instance = GetComponent<Tower>();
        }
        if(ingameManagerInstance == null){
            ingameManagerInstance = FindObjectOfType<GameMaker>();
        }
    }
}

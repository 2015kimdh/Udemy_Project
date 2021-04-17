using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKitItem : MonoBehaviour, IItem
{
    public int restoreHealth = 50;

    public void Use(){
        Debug.Log("체력 회복 50");
    
    PlayerForInterface player = FindObjectOfType<PlayerForInterface>();
    player.hp += restoreHealth;

    gameObject.SetActive(false);
    }
}

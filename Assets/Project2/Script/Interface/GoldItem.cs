using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldItem : MonoBehaviour, IItem
{
    public int goldAmount = 100;
    
    public void Use(){
        Debug.Log("골드를 먹었다");
        PlayerForInterface player = FindObjectOfType<PlayerForInterface>();
        player.gold += goldAmount;
        gameObject.SetActive(false);
    }
}

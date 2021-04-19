using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    // Start is called before the first frame update
    public void HealthBoost(CharacterEvent character){
        Debug.Log(character.playerName + "의 체력을 강화했다.");
        character.hp += 10;
    }
    public void ShieldBoost(CharacterEvent character){
        Debug.Log(character.defense + "의 방어력을 강화했다.");
        character.defense += 10;
    }
    public void DamageBoost(CharacterEvent character){
        Debug.Log(character.damage + "의 공격력을 강화했다.");
        character.damage += 10;
    }

    void Awake() {
        CharacterEvent player = FindObjectOfType<CharacterEvent>();
        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DamageBoost;
    }
}

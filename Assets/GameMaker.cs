using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour
{
    public List<int>[][] gameMap;
    public List<Tower> towerList;
    public List<Tower> enemyTowerList;

    private int inGameNumber;
    private int enemyInGameNumber;

    // Start is called before the first frame update
    public void AddMyID(Tower me){
        if(me.GetComponent<Faction>().whichTeam == Faction.factionType.friendly){
            me.inGameID = inGameNumber;
            Debug.Log(me.inGameID + " MyID");
            towerList.Add(me);
            inGameNumber += 1;
            
        }
        if(me.GetComponent<Faction>().whichTeam == Faction.factionType.enemy){
            me.inGameID = enemyInGameNumber;
            Debug.Log(me.inGameID + " MyID");
            enemyTowerList.Add(me);
            enemyInGameNumber += 1;
        }

    }
    void Awake()
    {
        towerList = new List<Tower>();
        enemyTowerList = new List<Tower>();
        inGameNumber = 0;
        enemyInGameNumber = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

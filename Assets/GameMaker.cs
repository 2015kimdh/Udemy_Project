using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaker : MonoBehaviour
{
    public List<Tower> towerList;
    // Start is called before the first frame update
    void AddMyID(Tower me){
        for(int i = 0; i < towerList.Count; i++){
            if(towerList[i].inGameID == me.inGameID)
                return;
        }
        towerList.Add(me);
    }
    void Awake()
    {
        towerList = new List<Tower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

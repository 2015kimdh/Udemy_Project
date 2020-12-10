using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;
    public bool isGameEnd;
    // Start is called before the first frame update
    void Start()
    {
        isGameEnd = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(isGameEnd)
        {
            return;
        }
        
        bool isGood = true;
        for(int i = 0; i < 3; i++){
            if(!itemBoxes[i].isCollide)
            {
                isGood = false;
            }
        }

        if(isGood == true){
            Debug.Log("게임 끝");
            isGameEnd = true;
        }
    }
}

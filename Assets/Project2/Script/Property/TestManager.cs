using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public PointManager pointManager;
    public MonsterManager monsterManager;
    // Start is called before the first frame update
    void Start()
    {
        pointManager.point = 100;
        int myPoint = pointManager.point;
        Debug.Log("현재 포인트: " + myPoint);

        pointManager.point = -100;
        myPoint = pointManager.point;
        Debug.Log("현재 포인트: " + myPoint);
        
        int numberOfMonster = monsterManager.count;
        Debug.Log("몬스터의 수 : " + numberOfMonster);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameMaker gameMasterInstance;
    [System.Serializable]
    public class Damage
    {
        public float ad;
        public float ap;
    }

    public class buff{
        enum buffType{
            buff,
            debuff
        }
        enum buffName{
            armorPiercing,
            looseMovility,
            stun,
            attackBuff,
            armorBuff
        }
        private buffType whichTypeOfBuff;
        private buffName whatfBuff;
        private float continueTime;  //
        private float rate;  //버프 디버프의 정도. %일 것임
        private int trgetID;
    }
    private int targetID;   //공격할 대상. 인게임에서 배치 순서대로 ID를 정해줄 것인데 그 ID를 가지고 공격할 대상 판단
    public int armorPoint;  //물리방어력
    public int magicArmorPoint; //마법저항력
    public int attackPoint; //공격력
    public float attackSpeed;   //공격 속도
    public int resistance;  //저지 수
    public float moveSpeed; //움직이는 속도. 아군의 경우 0. 움직이지 않음
    public float reEngageTime;  //리젠 시간
    private float bulletSpeed;  //투사체 속도. 0이면 근거리거나 즉발식
    public int attackRangeType;    //원거리거나 근거리거나. 0이면 근거리, 1이면 원거리, 2면 상관 없음. 스테이지 상에 배치시에 활용될 예정
    private List<buff> iGiveBuff;   //내가 가하고 있는 버프나 디버프
    private List<buff> iRecieveBuff;    //내가 당하고 있는 버프나 디버프
    private bool amIResist; // 내가 저지 당하고 있나?
    public int[] myPosition;
    private Vector3 direction;

    public int inGameID;

    public int GetTargetID(){
        return targetID;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameMasterInstance = GameObject.FindGameObjectWithTag
            ("GameMaker").GetComponent<GameMaker>();

        gameMasterInstance.AddMyID(this);   // 타워를 배치하여 처음 실행 될때 함
        

        Damage test = new Damage();
        test.ad = 10;
        test.ap = 20;

        var result = JsonUtility.ToJson(test);

        Debug.Log(result);

        var damage = JsonUtility.FromJson<Damage>(result);

        Debug.Log(damage.ad + " " + damage.ap);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

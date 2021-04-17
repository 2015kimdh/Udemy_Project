using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int point{
        get{
            return m_point;
        }

        set{
            if(value < 0){
                m_point = 0;
            }
            else{
                m_point = value;
            }
        }
    }
    private int m_point = 0;
    // Start is called before the first frame update
   
}

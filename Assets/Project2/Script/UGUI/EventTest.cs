using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class EventTest : MonoBehaviour, IPointerEnterHandler
{   
    public void OnPointerEnter(PointerEventData data){
        Debug.Log(data.position);
    }
}

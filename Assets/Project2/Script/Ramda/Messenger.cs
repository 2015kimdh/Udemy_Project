using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour
{
    public delegate void send(string reciever);

    send onSend;

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            onSend("Yea");
       }
    }
    void Start(){
        onSend += SendMail;
        onSend += SendMoney;
        onSend += man => Debug.Log("Assassinate " + man);

        onSend += (string man) => {Debug.Log("Assassinate " + man);
        Debug.Log("Hide Body");};
    }
    void SendMail(string reciever){
        Debug.Log("Mail sent to: " + reciever);
    }

    void SendMoney(string reciever){
        Debug.Log("Money sent to: " + reciever);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRotater : MonoBehaviour
{
    public enum RotateState {
        Idle,Vertical,Horizontal,Ready
    }

    private RotateState state = RotateState.Idle;

    private int initializeCount = 0;
    public RotateState State{
        get { return state;}
        set {
            state = value;
            initializeCount++;
        }
    }

    public float verticalRotateSpeed = 360f;
    public float horizontalRotateSpeed = 360f;

    public BallShooter ballShooter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        switch(state){
            case RotateState.Idle:
                 if(Input.GetButtonDown("Fire1")){
                     ballShooter.enabled = false;
                state = RotateState.Horizontal;
            }
            break;
            case RotateState.Vertical:
                if(Input.GetButton("Fire1")){
                transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));
            }
            else if(Input.GetButtonUp("Fire1")){
                state = RotateState.Ready;
            }
            break;
            case RotateState.Horizontal:
                if(Input.GetButton("Fire1")){
                transform.Rotate(new Vector3(0, horizontalRotateSpeed*Time.deltaTime,0));
            }
            else if(Input.GetButtonUp("Fire1")){
                state = RotateState.Vertical;
            }
            break;
            case RotateState.Ready:
                ballShooter.enabled = true;
            break;
        }

    }

    private void OnEnable() {
        transform.rotation = Quaternion.identity;
        state = RotateState.Idle;
        ballShooter.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public int menuIndex;
    [SerializeField] bool keyDown;
    [SerializeField] int maxIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") != 0){
            if(!keyDown){
                if(Input.GetAxis("Vertical") < 0){
                    if(menuIndex < maxIndex){
                        menuIndex++;
                    }
                }else{
                    //menuIndex = 0;
                }
            }else if(Input.GetAxis("Vertical") > 0){
                if(menuIndex > 0){
                    menuIndex--;
                }else{
                    //menuIndex = maxIndex;
                }
            }keyDown = true;
        }
        else{
            keyDown = false;
        }
    }
}
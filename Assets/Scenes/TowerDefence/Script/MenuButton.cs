using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    //[SerializeField] AnimatorFuntions animatorFuntions;
    [SerializeField] int thisIndex;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(menuButtonController.menuIndex == thisIndex){
            animator.SetBool("Selected", true);
            if(Input.GetAxis ("Submit") == 1){
                animator.SetBool("Pressed", true);
            }
            else if(animator.GetBool ("Pressed")){
                animator.SetBool("Pressed", false);
                //animatorFuntions.disableOnce = true;
            }
        }
        else{
                animator.SetBool ("Selected", false);
        }    
    }
}

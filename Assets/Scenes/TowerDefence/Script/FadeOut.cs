using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    private bool isFadeOut;
    private Color thisColor;
    // Start is called before the first frame update
    public void FadingOut(){
        if(thisColor.a < 255){
                thisColor.a += Time.deltaTime*1000;
                Debug.Log(thisColor.a);
            }
        else{
            SceneManager.LoadScene("GameScene");
        }
    }
    void Start()
    {
        //gameObject.SetActive(false);
        thisColor = gameObject.GetComponent<Image>().color;
        thisColor.a = 0;
        isFadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {   
        FadingOut();
    }
}

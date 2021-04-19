using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TextGameManager : MonoBehaviour
{
    public void OnPlayerDead(){
        Invoke("Restart",5f);
    }
    // Start is called before the first frame update
    void Restart(){
        SceneManager.LoadScene(0);
    }
}

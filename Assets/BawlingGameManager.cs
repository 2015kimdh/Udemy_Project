using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class BawlingGameManager : MonoBehaviour
{
    
    public UnityEvent onReset;
    public static BawlingGameManager instance;
    public GameObject readyPannel;
    public Text scoreText;
    public Text bestScoreText;
    public Text messageText;
    public bool isRoundActive = false;
    private int score = 0;
    public ShooterRotater shooterRotator;
    public CamFollow cam;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        UpdateUI();
    }

    void Start() {
        StartCoroutine("RoundRoutin");
    }

    public void AddScore(int newScore){
        score += newScore;
        UpdateBestScore();
        UpdateUI();
    }

    int GetBestScore(){
        int bestScore = PlayerPrefs.GetInt("BestScore");
        return bestScore;
    }
    void UpdateBestScore(){
        if(GetBestScore() < score){
            PlayerPrefs.SetInt("BestScore", score);
        }
    }

    void UpdateUI(){
        scoreText.text = "Score: " + score;
        bestScoreText.text = "Best Score: " + GetBestScore();
    }
    // Update is called once per frame
    public void OnBallDestroy()
    {
        UpdateUI();
        isRoundActive = false;
    }

    public void Reset(){
        score = 0;
        UpdateUI();
        StartCoroutine("RoundRoutin");
    }

    IEnumerator RoundRoutin(){
        onReset.Invoke();
        //READY
        readyPannel.SetActive(true);
        cam.SetTarget(shooterRotator.transform, CamFollow.State.Idle);
        shooterRotator.enabled = false;
        isRoundActive = false;
        messageText.text = "Ready...";
        yield return new WaitForSeconds(3f);
        //PLAY
        isRoundActive = true;
        readyPannel.SetActive(false);
        shooterRotator.enabled = true;
        cam.SetTarget(shooterRotator.transform,CamFollow.State.Ready);

        while(isRoundActive == true){
            yield return null;
        }
        //END
        readyPannel.SetActive(true);
        shooterRotator.enabled = false;
        messageText.text = "Wait for Next Round...";

        yield return new WaitForSeconds(3f);
        Reset();
    }
}

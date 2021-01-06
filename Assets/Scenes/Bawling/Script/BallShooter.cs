using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    public CamFollow cam;
    public ShooterRotater shooterRotater;
    public Rigidbody ball;
    public Transform firepos;
    public Slider powerSlider;
    public AudioSource shootingSound;
    public AudioClip fireclip;
    public AudioClip chargeclip;
    public float minForce = 15f;
    public float maxForce = 30f;
    public float chargingTime = 0.75f;
    private float currentForce;
    private float chargeSpeed;
    private bool fired;
    private void OnEnable() {
        currentForce = minForce;
        powerSlider.value = minForce;
        fired = false;
    }

    private void Start(){
        chargeSpeed = (maxForce - minForce)/chargingTime;
        
            fired = false;
    }

    private void Update(){

        if(fired == true){
            powerSlider.value = minForce;
            fired = false;
            return;
        }
        powerSlider.value = minForce;

        if(currentForce >= maxForce && !fired){
            currentForce = maxForce;
            Fire();
            //shooterRotater.State = ShooterRotater.RotateState.Idle;
            //shooterRotater.transform.rotation = Quaternion.identity;
            fired = false;
        }
        else if(Input.GetButtonDown("Fire1")){
            currentForce = minForce;
            shootingSound.clip = chargeclip;
            shootingSound.Play();
        }
        else if(Input.GetButton("Fire1") && !fired){
            currentForce = currentForce + chargeSpeed * Time.deltaTime;
            powerSlider.value = currentForce;
        }
        else if(Input.GetButtonUp("Fire1") && !fired){
            Fire();
            //shooterRotater.State = ShooterRotater.RotateState.Idle;
            //shooterRotater.transform.rotation = Quaternion.identity;
            fired = false;

        }
    }


    private void Fire(){
        fired = true;
        Rigidbody ballInstance = Instantiate(ball, firepos.position, firepos.rotation);
        ballInstance.velocity = currentForce * firepos.forward;
        shootingSound.clip = fireclip;
        shootingSound.Play();
        currentForce = minForce;
        cam.SetTarget(ballInstance.transform, CamFollow.State.Tracking);
    }
}

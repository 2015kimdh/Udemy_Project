using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;
    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;
    public float maxDamage = 100f;
    public float explosionForce = 1000f;
    public float lifeTime = 3f;
    public float explosionRadius = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other) {
        Collider[] colliders = Physics.OverlapSphere(transform.position,explosionRadius,whatIsProp);

        for(int i = 0; i < colliders.Length; i++){
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();
            targetRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            prop targetProp = colliders[i].GetComponent<prop>();
            float getDamage = CalculateDamage(colliders[i].transform.position);

            targetProp.TakeDamage(getDamage);
        }

        explosionParticle.transform.parent = null;
        explosionParticle.Play();
        explosionAudio.Play();
        
        BawlingGameManager.instance.OnBallDestroy();

        Destroy(explosionParticle.gameObject, explosionParticle.duration);
        Destroy(gameObject);
    }

    private float CalculateDamage(Vector3 targetPosition){
        Vector3 explosionToTarget = (targetPosition - transform.position);
        float distance = explosionToTarget.magnitude;
        float edgeToCenter = explosionRadius - distance;
        float percentage = edgeToCenter/explosionRadius;
        float damage = percentage * maxDamage;
        damage = Mathf.Max(0, damage);
        return damage;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForInterface : MonoBehaviour
{
    public float hp = 50;
    public int gold = 1000;
    private Rigidbody2D m_rigidboby;
    private float speed = 3f;
    private float jumpSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidboby = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        IItem item = other.GetComponent<IItem>();
        if(item != null){
            item.Use();
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 currentVelocity = m_rigidboby.velocity;
        float horizontal = Input.GetAxis("Horizontal");
        currentVelocity.x = horizontal*speed;

        if(Input.GetButtonDown("Jump")){
            currentVelocity.y = jumpSpeed;
        }

        m_rigidboby.velocity = currentVelocity;
    }
}

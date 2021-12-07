using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ojek : MonoBehaviour
{

    int maxHealth = 1;
    int currentHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
       {
            if(position.x < -14.5f)
            {
                position.x = -14.5f;
            }
            else if (position.x > 14f)
            {
                position.x = 14f;
            }
            else
            {
                position.x = position.x + 6.5f * horizontal * Time.deltaTime;
            }
       }
       else if(Input.GetKey(KeyCode.W))
       {
           position.y = position.y + 7f * vertical * Time.deltaTime;
       }
       else if(Input.GetKey(KeyCode.S))
       {
           position.y = position.y + 3.5f * vertical * Time.deltaTime;
       }
       transform.position = position;
    }

    void FixedUpdate()
    {
        Vector2 rigid_position = rigidbody2d.position;
        rigidbody2d.MovePosition(rigid_position);
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}

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
            if(position.x < -6.987047f)
            {
                position.x = -6.987047f;
            }
            else if (position.x > 12.86088f)
            {
                position.x = 12.86088f;
            }
            else
            {
                position.x = position.x + 2.5f * horizontal * Time.deltaTime;
            }
       }
       else if(Input.GetKey(KeyCode.W))
       {
           position.y = position.y + 3f * vertical * Time.deltaTime;
       }
       else if(Input.GetKey(KeyCode.S))
       {
           position.y = position.y + 1f * vertical * Time.deltaTime;
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

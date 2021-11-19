using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POKI : MonoBehaviour
{
    Rigidbody2D rigid;
    public bool v;
    public float changeTime = 3.0f;
    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigid.position;
        if (v)
        {
            position.y = position.y + Time.deltaTime * 3f;
        }
        else
        {
            position.x = position.x + Time.deltaTime * 3f;
        }
        rigid.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Ojek player = other.gameObject.GetComponent<Ojek >();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ojek : MonoBehaviour
{

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       position.x = position.x + 3f * horizontal * Time.deltaTime;
       position.y = position.y + 3f * vertical * Time.deltaTime;
        transform.position = position;
    }

    void FixedUpdate()
    {
        Vector2 rigid_position = rigidbody2d.position;
        rigidbody2d.MovePosition(rigid_position);
    }
}

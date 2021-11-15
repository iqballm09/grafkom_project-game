using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ojek : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");

       Vector2 position = transform.position;
       if (Input.GetKey(KeyCode.A))
       {
           if(position.x < -3.533976f)
           {
                position.x = -3.533976f;
           }
           else
           {
                position.x = position.x + 3f * horizontal * Time.deltaTime;
           }
       }
       if (Input.GetKey(KeyCode.D))
       {
           if(position.x > 3.533976f)
           {
                position.x = 3.533976f;
           }
           else
           {
                position.x = position.x + 3f * horizontal * Time.deltaTime;
           }
       }
       if (Input.GetKey(KeyCode.W))
       {
           position.y = position.y + 3f * vertical * Time.deltaTime;
       }
       else if (Input.GetKey(KeyCode.S))
       {
           position.y = position.y + 0.5f * vertical * Time.deltaTime;
       }
       transform.position = position;
    }
}

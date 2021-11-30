using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        public Transform bg1, bg2;
        private float size_bg;

        public float lerpSpeed = 1.0f;

        private Vector3 offset;

        private Vector3 targetPos;

        private void Start()
        {
            if (target == null) return;
            if (bg1 == null) return;
            if (bg2 == null) return;

            offset = transform.position - target.position;

            //size_bg = bg1.GetComponent<Renderer>().bounds.size.y;
            size_bg = 148.5f;
        }

        private void Update()
        {
            //camera
            if (target == null) return;

            targetPos = target.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPos, lerpSpeed * Time.deltaTime);

            //background
            if (bg1 == null) return;
            if (bg2 == null) return;

            if(transform.position.y >= bg2.position.y)
            {
                bg1.position = new Vector3(bg1.position.x, bg2.position.y + size_bg, bg1.position.z);
                SwitchBg();
            }
            if(transform.position.y < bg1.position.y)
            {
                bg2.position = new Vector3(bg2.position.x, bg1.position.y - size_bg, bg2.position.z);
                SwitchBg();
            }
        }

        private void SwitchBg()
        {
            Transform temp = bg1;
            bg1 = bg2;
            bg2 = temp;
        }
    }
}

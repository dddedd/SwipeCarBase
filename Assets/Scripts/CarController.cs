using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    // Update is called once per frame
    float speed = 0.0f;
    Vector2 startPos;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            //this.speed = 0.5f;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - startPos.x);
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        speed *= 0.98f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startPos, endPos, direction; // touch start position, end position, swipe direction
    float touchTimeStart, touchTimeFinish, timeInterval; // to calculate swipe time
    [Range(0.05f, 1f)] // slider for inspector window
    public float throwForse = 0.3f; // to control throw forse
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if you touch the screen
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //getting touch position and marking time when you touch the screen
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }
        // if you release your finger
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            // marking time when you release it
            touchTimeFinish = Time.time;
            // calculate swipe time interval
            timeInterval = touchTimeFinish - touchTimeStart;
            // getting release finger position
            endPos = Input.GetTouch(0).position;
            // calculating swipe direction
            direction = startPos - endPos;
            // add force to ball rigidbody depending on swipe time and direction
            GetComponent<Rigidbody2D>().AddForce(-direction / timeInterval * throwForse);
        }
    }
}

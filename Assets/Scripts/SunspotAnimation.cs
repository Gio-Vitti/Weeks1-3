using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunspotAnimation : MonoBehaviour
{
    //Animation Curve
    public AnimationCurve size;

    //Range
    [Range(0, 1)]
    public float s;

    //Globe Quadrant
    public int quad = 0;

    // Update is called once per frame
    void Update()
    {
        //Assign local scale to s variabale on the animation curve
        transform.localScale = Vector2.one * size.Evaluate(s);

        //Change current quadrant when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            quad += 1;
        }

        //Grow on quadrant 1, shrink on all the others
        if (quad == 1 & s <= 1)
        {
            s += 0.5f * Time.deltaTime;
        } else if (s >= 0)
        {
            s -= 1 * Time.deltaTime;
        }
        
       //Reset quadrant
        if (quad > 3)
        {
            quad = 0;
        }
    }
}

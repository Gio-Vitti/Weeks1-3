using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningGlobe : MonoBehaviour
{
    //Variables:

    //Globe Quadrant
    int quad = 0;

    //Flag for the globe's spinning state
    bool currentlySpinning = false;

    //Rotation Speed
    public float rotationSpeed;

    //Rotation Amount
    public float rotationAmount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        Vector3 spin = transform.eulerAngles;

        //Change current quadrant when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentlySpinning = true;
            quad += 1;
        }

        //Rotate globe until it reaches the next quadrant
        if (currentlySpinning == true && rotationAmount <= 90)
        {
            spin.z -= rotationSpeed ;
            rotationAmount += rotationSpeed;
        } else //Set rotation to quad * 90 so there is no gradual offset when spinning multiple times
        {
            currentlySpinning = false;
            rotationAmount = 0;
            spin.z = 360 - (quad * 90);
        }
       
        //Reset Quadrant variable
        if (quad > 3)
        {
            quad = 0;
        }

        transform.eulerAngles = spin;
    }
}

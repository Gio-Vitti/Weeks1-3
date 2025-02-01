using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot2 : MonoBehaviour
{
    //Variables:

    //Globe Quadrant
    public int quad = 0;

    //Flag for the globe's spinning state
    public bool currentlySpinning = false;

    //Rotation Speed
    public float rotationSpeed;
    //Rotation Amount
    public float rotationAmount;

    public float rot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        Vector3 spin = transform.eulerAngles;
        rot = spin.z;

        //Change current quadrant when the space bar is pressed

        if (Input.GetKeyDown(KeyCode.Space) && quad == 0 || Input.GetKeyDown(KeyCode.Space) && quad >= 2)
        {
            currentlySpinning = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            quad += 1;
        }

        //Rotate globe until it reaches the next quadrant
        if (currentlySpinning == true && rotationAmount <= 90 )
        {
            spin.z -= rotationSpeed;
            rotationAmount += rotationSpeed;
        }
        else if (quad == 1) //Set rotation to quad * 90 so there is no gradual offset when spinning multiple times
        {
            currentlySpinning = false;
            rotationAmount = 0;
            spin.z = 270;
        } else
        {
            currentlySpinning = false;
            rotationAmount = 0;
        }


        //Reset Quadrant variable
        if (quad > 3)
        {
            spin.z = 90;
            quad = 0;
        }

        transform.eulerAngles = spin;
    }
}



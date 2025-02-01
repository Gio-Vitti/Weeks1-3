using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot1 : MonoBehaviour
{
    //Variables:

    //Globe Quadrant
    public int quad = 0;

    //Flag for the globe's spinning state
    bool currentlySpinning = false;

    //Flag for spinning backwards state when passing quadrant 3
    bool spinBackwards = false;

    //Rotation Speed
    float rotationSpeed = 0.5f;

    //Rotation Amount
    float rotationAmount;
    float backwardsAmount;


    // Update is called once per frame
    void Update()
    {
        //Rotation
        Vector3 spin = transform.eulerAngles;


        //Activate spinning when on the correct quadrant
        if (Input.GetKeyDown(KeyCode.Space) && quad == 1)
        {
            currentlySpinning = true;
        }

        //Change current quadrant when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            quad += 1;
        }

        //Rotate globe until it reaches the next quadrant
        if (currentlySpinning == true && rotationAmount <= 90)
        {
            spin.z -= rotationSpeed;
            rotationAmount += rotationSpeed;
        }
        else 
        {
            currentlySpinning = false;
            rotationAmount = 0;
        }

        //Reset Quadrant variable and initial rotation, enable bacwards rotation
        if (quad > 3)
        {
            quad = 0;
            spinBackwards = true;
        }

        //Rotate counter clockwise until reaching quadrant 0 
        if (spinBackwards == true && backwardsAmount <= 90)
        {
            spin.z += rotationSpeed;
            backwardsAmount += rotationSpeed;
        } else
        {
            spinBackwards = false;
            backwardsAmount = 0;
        }

        transform.eulerAngles = spin;
    }
}


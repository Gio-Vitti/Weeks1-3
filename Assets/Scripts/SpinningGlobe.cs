using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningGlobe : MonoBehaviour
{
    //Variables:

    //Globe Quadrant
    public int quad = 0;
    public float targetAngle;

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
        targetAngle = spin.z;

        //Change current quadrant based on arrow input
        if (Input.GetKeyDown(KeyCode.Space) && currentlySpinning == false)
        {
            currentlySpinning = true;
            quad += 1;
        }

        if (currentlySpinning == true && rotationAmount <= 90)
        {
            spin.z -= rotationSpeed;
            rotationAmount += rotationSpeed;
        } else
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

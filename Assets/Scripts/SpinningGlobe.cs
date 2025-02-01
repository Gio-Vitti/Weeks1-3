using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningGlobe : MonoBehaviour
{
    //Variables:

    //Globe Quadrant
    public int quad = 1;

    [Range(0,360)]
    public int targetAngle;

    bool currentlySpinning;

    //Rotation Speed
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        Vector3 spin = transform.eulerAngles;

        //Change current quadrant based on arrow input
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentlySpinning == false)
        {
            targetAngle += 90;
        }

        if (spin.z < targetAngle)
        {
            spin.z += rotationSpeed;
        }
        transform.eulerAngles = spin;
    }
}

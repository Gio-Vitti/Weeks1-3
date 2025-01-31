using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowMouse : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Follow Mouse
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;

        //Rotate
        Vector3 rot = transform.eulerAngles;
            rot.z = rot.z + 5;
            transform.eulerAngles = rot;
       
    }
}

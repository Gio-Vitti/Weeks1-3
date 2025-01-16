using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float xSpeed = 50f;
    public float ySpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += xSpeed * Time.deltaTime;
        pos.y -= ySpeed * Time.deltaTime;
        transform.position = pos;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);

        //Bounce around screen
        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            xSpeed = xSpeed * -1;
        }

        if (squareInScreenSpace.y < 0 || squareInScreenSpace.y > Screen.height)
        {
            ySpeed = ySpeed * -1;

        }

        //Change speed
        
    }
}

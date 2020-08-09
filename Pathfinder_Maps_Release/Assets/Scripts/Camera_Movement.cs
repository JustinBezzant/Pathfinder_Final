using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    private float transVelUp;
    private float transVelDown;
    private float transVelLeft;
    private float transVelRight;
    public float transAccel;
    public float maxSpeed;
    public float maxZ, minZ,maxX,minX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (gameObject.transform.position.z < maxZ)
            {
                transVelUp = transVelUp + transAccel;
                if (transVelUp > maxSpeed)
                {
                    transVelUp = maxSpeed;
                }
                gameObject.transform.Translate(0, transVelUp, 0);
            }
        }
        else
        {
            transVelUp = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (gameObject.transform.position.z > minZ)
            {

                transVelDown = transVelDown - transAccel;
                if (transVelDown > maxSpeed)
                {
                    transVelDown = maxSpeed;
                }
                gameObject.transform.Translate(0, transVelDown, 0);
            }
        }
        else
        {
            transVelDown = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (gameObject.transform.position.x > minX)
            {
                transVelLeft = transVelLeft - transAccel;
                if (transVelLeft > maxSpeed)
                {
                    transVelLeft = maxSpeed;
                }
                gameObject.transform.Translate(transVelLeft, 0, 0);
            }
        }
        else
        {
            transVelLeft = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (gameObject.transform.position.x < maxX)
            {
                transVelRight = transVelRight + transAccel;
                if (transVelRight > maxSpeed)
                {
                    transVelRight = maxSpeed;
                }
                gameObject.transform.Translate(transVelRight, 0, 0);
            }
        }
        else
        {
            transVelRight = 0;
        }
    }
}

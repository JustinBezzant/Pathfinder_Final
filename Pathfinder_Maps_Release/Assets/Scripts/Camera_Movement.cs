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
    public bool activeCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeCamera == true)
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
                    if (Mathf.Abs(transVelDown) > maxSpeed)
                    {
                        transVelDown = -1 * maxSpeed;
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
                    if (Mathf.Abs(transVelLeft) > maxSpeed)
                    {
                        transVelLeft = -1 * maxSpeed;
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
    public void Camera_Select()
    {
        activeCamera = true;
    }
    public void Camera_Deselect()
    {
        activeCamera = false;
    }
}

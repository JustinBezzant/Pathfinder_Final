using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Scroll : MonoBehaviour
{
    public float maxZoom;
    public float maxZoomOut;
    public float scrollSpeed;
    private float cameraMove;
    private Vector3 mousePos;
    public bool activeCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeCamera == true)
        {
            if (Input.mouseScrollDelta.y < 0)
            {
                Debug.Log("hi");
                cameraMove = -1f * scrollSpeed;
                if (transform.position.y < maxZoomOut)
                {
                    transform.Translate(new Vector3(0, 0, -1 * scrollSpeed));
                }
            }
            else if (Input.mouseScrollDelta.y > 0)
            {
                cameraMove = scrollSpeed;
                if (transform.position.y > maxZoom)
                {
                    transform.Translate(new Vector3(0, 0, scrollSpeed));
                }
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

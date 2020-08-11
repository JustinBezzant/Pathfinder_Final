using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Object_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask Targetable;
    public float TokenPositions;
    private GameObject Selected;
    private UnityEngine.Vector3 Reposition;
    void Start()
    {
        Selected = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit,Mathf.Infinity,Targetable))
            {
                Selected = hit.collider.gameObject;
            }
            
        }
        if (Input.GetMouseButtonDown(1) && Selected != null)
        {
            Reposition = Camera.main.ScreenToWorldPoint(new UnityEngine.Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y - TokenPositions));
            Reposition = new UnityEngine.Vector3(Mathf.Round(Reposition.x),Reposition.y, Mathf.Round(Reposition.z));
            Selected.transform.position = Reposition;
            //Selected.transform.position = Camera.main.ScreenToWorldPoint(new UnityEngine.Vector3(Mathf.Round (Input.mousePosition.x), Mathf.Round (Input.mousePosition.y), Camera.main.transform.position.y - TokenPositions));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Hide()
    {
        Selected.layer = 9; //GM Layer
    }
    public void Reveal()
    {
        Selected.layer = 8; //all Players
    }
    public void Kill()
    {
        Destroy(Selected);
    }

}

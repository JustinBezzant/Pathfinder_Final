using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Camera_Hotkeys : MonoBehaviour
{
    public GameObject GMCamera;
    public GameObject PCCamera;
    private bool GM_Active;
    private bool PC_Active;


    // Start is called before the first frame update
    void Start()
    {
        GM_Active = true;
        PC_Active = false;
    }

    // Update is called once per frame
    public void set1()
    {
        if(GM_Active == true)
        {
            gameObject.transform.GetChild(0).transform.position = GMCamera.transform.position;
        }
        if(PC_Active == true)
        {
            gameObject.transform.GetChild(0).transform.position = PCCamera.transform.position;
        }
    }
    public void set2()
    {
        if (GM_Active == true)
        {
            gameObject.transform.GetChild(1).transform.position = GMCamera.transform.position;
        }
        if (PC_Active == true)
        {
            gameObject.transform.GetChild(1).transform.position = PCCamera.transform.position;
        }
    }
    public void set3()
    {
        if (GM_Active == true)
        {
            gameObject.transform.GetChild(2).transform.position = GMCamera.transform.position;
        }
        if (PC_Active == true)
        {
            gameObject.transform.GetChild(2).transform.position = PCCamera.transform.position;
        }
    }
    public void set4()
    {
        if (GM_Active == true)
        {
            gameObject.transform.GetChild(3).transform.position = GMCamera.transform.position;
        }
        if (PC_Active == true)
        {
            gameObject.transform.GetChild(3).transform.position = PCCamera.transform.position;
        }
    }
    public void set5()
    {
        if (GM_Active == true)
        {
            gameObject.transform.GetChild(4).transform.position = GMCamera.transform.position;
        }
        if (PC_Active == true)
        {
            gameObject.transform.GetChild(4).transform.position = PCCamera.transform.position;
        }
    }
    public void jump1()
    {
        if(GM_Active == true)
        {
            GMCamera.transform.position = gameObject.transform.GetChild(0).position;
        }
        if(PC_Active == true)
        {
            PCCamera.transform.position = gameObject.transform.GetChild(0).position;
        }
    }
    public void jump2()
    {
        if (GM_Active == true)
        {
            GMCamera.transform.position = gameObject.transform.GetChild(1).position;
        }
        if (PC_Active == true)
        {
            PCCamera.transform.position = gameObject.transform.GetChild(1).position;
        }
    }
    public void jump3()
    {
        if (GM_Active == true)
        {
            GMCamera.transform.position = gameObject.transform.GetChild(2).position;
        }
        if (PC_Active == true)
        {
            PCCamera.transform.position = gameObject.transform.GetChild(2).position;
        }
    }
    public void jump4()
    {
        if (GM_Active == true)
        {
            GMCamera.transform.position = gameObject.transform.GetChild(3).position;
        }
        if (PC_Active == true)
        {
            PCCamera.transform.position = gameObject.transform.GetChild(3).position;
        }
    }
    public void jump5()
    {
        if (GM_Active == true)
        {
            GMCamera.transform.position = gameObject.transform.GetChild(4).position;
        }
        if (PC_Active == true)
        {
            PCCamera.transform.position = gameObject.transform.GetChild(4).position;
        }
    }

    public void GM_Activate()
    {
        GM_Active = true;
        PC_Active = false;
    }
    public void PC_Activate()
    {
        PC_Active = true;
        GM_Active = false;
    }
}

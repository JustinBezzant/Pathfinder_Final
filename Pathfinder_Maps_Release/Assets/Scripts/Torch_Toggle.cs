using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch_Toggle : MonoBehaviour
{
    public Light torch;
    public bool isEnabled = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isEnabled = !isEnabled;
            torch.enabled = isEnabled;
        }
    }
}

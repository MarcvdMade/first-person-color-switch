using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorObject : MonoBehaviour
{
    public GameObject playerCam;
    public int lensNumber;

    public bool visableWhenColor = true;
    private PlayerCam script;

    void Start()
    {
        script = playerCam.GetComponent<PlayerCam>();
    }

    void Update()
    {
        if (visableWhenColor)
        {
            if (script.selectedLens == lensNumber)
            {
                GetComponent<MeshRenderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
            }
        }
        else
        {
            if (script.selectedLens == lensNumber)
            {
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<Collider>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
                GetComponent<Collider>().enabled = true;
            }
        }
    }
}

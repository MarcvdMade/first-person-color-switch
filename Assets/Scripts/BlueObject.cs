using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BlueObject : MonoBehaviour
{
    public GameObject playerCam;
    private PlayerCam script;

    void Start()
    {
        script = playerCam.GetComponent<PlayerCam>();
    }

    void Update()
    {
        if (script.selectedLens == 1)
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
}

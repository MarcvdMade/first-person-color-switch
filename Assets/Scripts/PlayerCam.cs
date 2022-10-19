using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlayerCam : MonoBehaviour
{
    public float sensX, sensY;

    public Transform orientation;

    float xRotation, yRotation;

    public GameObject PostProcess;

    public int selectedLens = 0;
    public PostProcessProfile[] lenses;

    private PostProcessVolume volume;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        volume = PostProcess.GetComponent<PostProcessVolume>();
    }

    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedLens < lenses.Length -1)
            {
                selectedLens++;
            }
            else
            {
                selectedLens = 0;
            }
            volume.profile = lenses[selectedLens];
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// kod från https://www.youtube.com/watch?v=c6NXkZWXHnc&t=213s

// access token mapbox pk.eyJ1Ijoia2hvdnN0YWRpdXMiLCJhIjoiY2pmbnFqNzl2MXZiMjJxbnozcXUzd2ZyYyJ9.IPtCW5LWVGBUI1BHhSyfxw

public class PhoneCamera : MonoBehaviour
{
    private bool camAvailable;
    private WebCamTexture backCamera;
    private Texture defaultBackground;

    public RawImage background;
    public AspectRatioFitter fit;

    private void Start()
    {
        defaultBackground = background.texture;
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {
            Debug.Log("No camera detected");
            camAvailable = false;
            return;

        }

        for (int i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
                backCamera = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if (backCamera == null)
        {
            Debug.Log("Unable to find back camera");
            return;
        }

        backCamera.Play();

        //Rendera bakkameran på rawimage
        background.texture = backCamera;

        camAvailable = true;

    }

    private void Update()
    {
        if (!camAvailable)
            return;

        //aspectratio
        float ratio = (float)backCamera.width / (float)backCamera.height;
        fit.aspectRatio = ratio;

        float scaleY = backCamera.videoVerticallyMirrored ? -1f : 1f; //if true =-1 else=1
        background.rectTransform.localScale = new Vector3(1f, scaleY, 1f);

        int orient = -backCamera.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orient);

    }
}

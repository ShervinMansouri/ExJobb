using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGpsText : MonoBehaviour {


    public Text coordinates;
    // Use this for initialization

    private void Update()
    {
        coordinates.text = "Lat:" + GPS.Instance.latitude.ToString() + "Lon:" + GPS.Instance.longitude.ToString();
    }


}

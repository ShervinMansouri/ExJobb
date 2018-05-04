using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mapbox.Unity.Location;

public class CanvasController : MonoBehaviour
{
    private LocationStatus ls;
    private AbstractLocationProvider m_locationProvider;
    
    public Canvas m_canvas;
    //public double m_minLatitude, m_maxLatitude, m_minLongitude, m_maxLongitude;

    public Button button;

    //public bool canBePlayed = false;
    
	// Use this for initialization
	void Start ()
    {
        //m_canvas.enabled = false;

        //if (null == m_locationProvider)
        //{
        //    m_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
        //}
        //Button btn = button.GetComponent<Button>();
        //button.onClick.AddListener(TaskOnClick);

    }

    //public void setBool(bool set )
    //{
    //    canBePlayed = set;
    //}

    //void TaskOnClick()
    //{
    //    canBePlayed = true;
    //    Debug.Log("You have clicked the button!");
    //}

    // Update is called once per frame
    void Update ()
    {
        //Location currLoc = m_locationProvider.CurrentLocation;

        //if (currLoc.LatitudeLongitude.x > m_minLatitude && currLoc.LatitudeLongitude.x < m_maxLatitude && currLoc.LatitudeLongitude.y > m_minLongitude && currLoc.LatitudeLongitude.y < m_maxLongitude && canBePlayed)
        //{

        //    m_canvas.enabled = true;
        //}
        //if (ls.latitude > m_minLatitude && ls.latitude < m_maxLatitude && ls.longitude > m_minLongitude && ls.longitude < m_maxLongitude && canBePlayed)
        //{

        //    m_canvas.enabled = true;
        //}

    }
}

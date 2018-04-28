using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mapbox.Unity.Location;

public class CanvasController : MonoBehaviour
{
    private AbstractLocationProvider m_locationProvider;
    
    public Canvas m_canvas;
    public float m_minLatitude, m_maxLatitude, m_minLongitude, m_maxLongitude;


	// Use this for initialization
	void Start ()
    {
        m_canvas.enabled = false;
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Location currLoc = m_locationProvider.CurrentLocation;

        if (currLoc.LatitudeLongitude.x > m_minLatitude && currLoc.LatitudeLongitude.x < m_maxLatitude && currLoc.LatitudeLongitude.y > m_minLongitude && currLoc.LatitudeLongitude.y < m_maxLongitude)
        {
            m_canvas.enabled = true;
        }

    }
}

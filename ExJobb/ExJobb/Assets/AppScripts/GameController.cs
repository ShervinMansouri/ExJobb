using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    
    public double lat;
    public double lon;

    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;
    public GameObject canvas5;
    public GameObject canvas6;
    public GameObject canvas7;

    public bool Quest1canBePlayed = false;
    public bool Quest2canBePlayed = false;
    public bool Quest3canBePlayed = false;
    public bool Quest4canBePlayed = false;
    public bool Quest5canBePlayed = false;
    public bool Quest6canBePlayed = false;
    public bool Quest7canBePlayed = false;

    public double minLatQ1, maxLatQ1, minLongQ1, maxLongQ1, minLatQ2, maxLatQ2, minLongQ2, maxLongQ2, minLatQ3, maxLatQ3, minLongQ3, maxLongQ3;
    public double minLatQ4, maxLatQ4, minLongQ4, maxLongQ4, minLatQ5, maxLatQ5, minLongQ5, maxLongQ5, minLatQ6, maxLatQ6, minLongQ6, maxLongQ6, minLatQ7, maxLatQ7, minLongQ7, maxLongQ7;

    // Use this for initialization
    void Start()
    {
        


    }

    public void setBoolQ1(bool set)
    {
        Quest1canBePlayed = set;
    }

    public void setBoolQ2(bool set)
    {
        Quest2canBePlayed = set;
    }
    public void setBoolQ3(bool set)
    {
        Quest3canBePlayed = set;
    }
    public void setBoolQ4(bool set)
    {
        Quest4canBePlayed = set;
    }
    public void setBoolQ5(bool set)
    {
        Quest5canBePlayed = set;
    }
    public void setBoolQ6(bool set)
    {
        Quest6canBePlayed = set;
    }
    public void setBoolQ7(bool set)
    {
        Quest7canBePlayed = set;
    }

    
    // Update is called once per frame
    void Update ()
    {
        lat = LocationStatus.latitude;
        lon = LocationStatus.longitude;

        if (lat > minLatQ1 && lat < maxLatQ1 && lon > minLongQ1 && lon < maxLongQ1 && Quest1canBePlayed == true)
        {
            canvas1.gameObject.SetActive(true);
            Quest1canBePlayed = false;
            
        }

        if (lat > minLatQ2 && lat < maxLatQ2 && lon > minLongQ2 && lon < maxLongQ2 && Quest2canBePlayed)
        {
            canvas2.gameObject.SetActive(true);
            Quest2canBePlayed = false;
        }
        if (lat > minLatQ3 && lat < maxLatQ3 && lon > minLongQ3 && lon < maxLongQ3 && Quest3canBePlayed)
        {
            canvas3.gameObject.SetActive(true);
            Quest3canBePlayed = false;
        }
        if (lat > minLatQ4 && lat < maxLatQ4 && lon > minLongQ4 && lon < maxLongQ4 && Quest4canBePlayed)
        {
            canvas4.gameObject.SetActive(true);
            Quest4canBePlayed = false;
        }
        if (lat > minLatQ5 && lat < maxLatQ5 && lon > minLongQ5 && lon < maxLongQ5 && Quest5canBePlayed)
        {
            canvas5.gameObject.SetActive(true);
            Quest5canBePlayed = false;
        }
        if (lat > minLatQ6 && lat < maxLatQ6 && lon > minLongQ6 && lon < maxLongQ6 && Quest6canBePlayed)
        {
            canvas6.gameObject.SetActive(true);
            Quest6canBePlayed = false;
        }
        if (Quest7canBePlayed)
        {
            canvas7.gameObject.SetActive(true);
            Quest7canBePlayed = false;
        }
    }
}

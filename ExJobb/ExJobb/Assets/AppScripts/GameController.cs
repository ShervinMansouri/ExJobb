using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Canvas Canvas1;
    public Canvas Canvas2;
    public Canvas Canvas3;
    public Canvas Canvas4;
    public Canvas Canvas5;
    public Canvas Canvas6;
    public Canvas Canvas7;
    
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
        Canvas1.enabled = false;
        Canvas2.enabled = false;
        Canvas3.enabled = false;
        Canvas4.enabled = false;
        Canvas5.enabled = false;
        Canvas6.enabled = false;
        Canvas7.enabled = false;

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
        if (LocationStatus.latitude > minLatQ1 && LocationStatus.latitude < maxLatQ1 && LocationStatus.longitude > minLongQ1 && LocationStatus.longitude < maxLongQ1 && Quest1canBePlayed)
        {
            Canvas1.enabled = true;
        }

        if (LocationStatus.latitude > minLatQ2 && LocationStatus.latitude < maxLatQ2 && LocationStatus.longitude > minLongQ2 && LocationStatus.longitude < maxLongQ2 && Quest2canBePlayed)
        {
            Canvas2.enabled = true;
        }
        if (LocationStatus.latitude > minLatQ3 && LocationStatus.latitude < maxLatQ3 && LocationStatus.longitude > minLongQ3 && LocationStatus.longitude < maxLongQ3 && Quest3canBePlayed)
        {
            Canvas3.enabled = true;
        }
        if (LocationStatus.latitude > minLatQ4 && LocationStatus.latitude < maxLatQ4 && LocationStatus.longitude > minLongQ4 && LocationStatus.longitude < maxLongQ4 && Quest4canBePlayed)
        {
            Canvas4.enabled = true;
        }
        if (LocationStatus.latitude > minLatQ5 && LocationStatus.latitude < maxLatQ5 && LocationStatus.longitude > minLongQ5 && LocationStatus.longitude < maxLongQ5 && Quest5canBePlayed)
        {
            Canvas5.enabled = true;
        }
        if (LocationStatus.latitude > minLatQ6 && LocationStatus.latitude < maxLatQ6 && LocationStatus.longitude > minLongQ6 && LocationStatus.longitude < maxLongQ6 && Quest6canBePlayed)
        {
            Canvas6.enabled = true;
        }
        if (Quest7canBePlayed)
        {
            Canvas7.enabled = true;
        }
    }
}

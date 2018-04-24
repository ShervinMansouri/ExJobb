using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image healthBar;

    public float maxTime = 10f;
    float timeLeft;
    public GameObject lifeLostText;

	// Use this for initialization
	void Start ()
    {
        lifeLostText.SetActive(false);
        healthBar = GetComponent<Image>();
        timeLeft = maxTime;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            healthBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            lifeLostText.SetActive(true);
            Time.timeScale = 0;
        }
	}
}

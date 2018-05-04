
	using Mapbox.Unity.Location;
	using Mapbox.Utils;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	public class LocationStatus : MonoBehaviour
	{

    //public static LocationStatus location_Instance { set; get; }

	[SerializeField]
	Text _statusText;

    [SerializeField]
    public static double latitude { get; set; }
    [SerializeField]
    public static double longitude { get; set; }

    private AbstractLocationProvider _locationProvider = null;

		void Start()
		{
        //location_Instance = this;
        //DontDestroyOnLoad(gameObject);

        if (null == _locationProvider)
			{
				_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
			}
		}


		void Update()
		{
			Location currLoc = _locationProvider.CurrentLocation;

			if (currLoc.IsLocationServiceInitializing)
			{
				_statusText.text = "location services are initializing";
			}
			else
			{
				if (!currLoc.IsLocationServiceEnabled)
				{
					_statusText.text = "location services not enabled";
				}
				else
				{
					if (currLoc.LatitudeLongitude.Equals(Vector2d.zero))
					{
						_statusText.text = "Waiting for location ....";
					}
					else
					{
						_statusText.text = string.Format("{0}", currLoc.LatitudeLongitude);

                        latitude = currLoc.LatitudeLongitude.x;
                        longitude = currLoc.LatitudeLongitude.y;
                        
					}
				}
			}

		}
	}


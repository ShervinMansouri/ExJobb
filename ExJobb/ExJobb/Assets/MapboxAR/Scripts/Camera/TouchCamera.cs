﻿//namespace Mapbox.Examples
//{
	// Just add this script to your camera. It doesn't need any configuration.

	using UnityEngine;
	using Mapbox.Unity.Location;
    using UnityEngine.UI;
    public class TouchCamera : MonoBehaviour
    {
        [SerializeField]
        Camera _camera;

        [SerializeField]
        TransformLocationProvider _locationProvider;

        Vector2?[] oldTouchPositions = { null, null };

        Vector2 oldTouchVector;
        Vector3 _delta;
        float oldTouchDistance;
        Vector3 _origin;
        int maxZoom = 30;
        int minZoom = 145;
        Vector3 resetCameraMax = new Vector3 (13, 33, 99);
        Vector3 resetCameraMin = new Vector3(29, 145, -50);
        Vector3 resetCamera = new Vector3(0, 100, -20);

        bool _wasTouching;

		bool _shouldDrag;
        public void CenterCamera()
        {
        _camera.transform.position = resetCamera;
        _shouldDrag = false;
        }
        void Update()
		{
            resetCameraMax = new Vector3(transform.position.x, 33, transform.position.z);
            resetCameraMin = new Vector3(transform.position.x, 145, transform.position.z);

            if (Input.touchCount == 0)
			{
				oldTouchPositions[0] = null;
				oldTouchPositions[1] = null;
				_shouldDrag = false;
				if (_wasTouching)
				{
					if (_locationProvider != null)
					{
						_locationProvider.SendLocationEvent();
                        
					}
					_wasTouching = false;
				}
			}
			else if (Input.touchCount == 1)
			{
				_wasTouching = true;
				if (oldTouchPositions[0] == null || oldTouchPositions[1] != null)
				{
					oldTouchPositions[0] = Input.GetTouch(0).position;
					oldTouchPositions[1] = null;
				}
				else
				{
                    if (_camera.transform.position.y > maxZoom || _camera.transform.position.y < minZoom)
                    {
                        //_camera.transform.position.y = 35;
                        //_camera.transform.localPosition = resetCameraY;
                        
                        Vector3 newTouchPosition = Input.GetTouch(0).position;
                        newTouchPosition.z = _camera.transform.localPosition.y;

                        _delta = _camera.ScreenToWorldPoint(newTouchPosition) - _camera.transform.localPosition;

                        if (_shouldDrag == false)
                        {
                            _shouldDrag = true;
                            _origin = _camera.ScreenToWorldPoint(newTouchPosition);
                        }

                        oldTouchPositions[0] = newTouchPosition;
                        _camera.transform.localPosition = _origin - _delta;
                    }
                    if(_camera.transform.position.y < maxZoom)
                    {
                        _camera.transform.localPosition = resetCameraMax;

                    }
                    
                    if(_camera.transform.position.y > minZoom)
                    {
                        _camera.transform.localPosition = resetCameraMin;

                    }
                }
			}
			else
			{
				_wasTouching = true;
				if (oldTouchPositions[1] == null)
				{
					oldTouchPositions[0] = Input.GetTouch(0).position;
					oldTouchPositions[1] = Input.GetTouch(1).position;
					oldTouchVector = (Vector2)(oldTouchPositions[0] - oldTouchPositions[1]);
					oldTouchDistance = oldTouchVector.magnitude;
				}
				else
				{
					//Vector2 screen = new Vector2(_camera.pixelWidth, _camera.pixelHeight);

					Vector2[] newTouchPositions = { Input.GetTouch(0).position, Input.GetTouch(1).position };
					Vector2 newTouchVector = newTouchPositions[0] - newTouchPositions[1];
					float newTouchDistance = newTouchVector.magnitude;
					transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, Mathf.Asin(Mathf.Clamp((oldTouchVector.y * newTouchVector.x - oldTouchVector.x * newTouchVector.y) / oldTouchDistance / newTouchDistance, -1f, 1f)) / 0.0174532924f));
					oldTouchPositions[0] = newTouchPositions[0];
					oldTouchPositions[1] = newTouchPositions[1];
					oldTouchVector = newTouchVector;
					oldTouchDistance = newTouchDistance;
				}
			}
		}
	}
//}

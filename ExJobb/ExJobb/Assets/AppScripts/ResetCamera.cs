using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour {
    [SerializeField]
    Camera _camera;
    Vector3 resetCamera = new Vector3(0, 94, 96);

    // Use this for initialization
    void Start () {
		
	}
    public void CenterCamera()
    {

        _camera.transform.position = resetCamera;
    }
    // Update is called once per frame
    void Update () {
		
	}
}

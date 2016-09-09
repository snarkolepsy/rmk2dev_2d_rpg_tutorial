using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float m_speed = 0.1f;
    Camera myCam;

	// Use this for initialization
	void Start () {
        myCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
        // optional, fixes scaling of pixels
        myCam.orthographicSize = (Screen.height / 100.0f) / 3.0f; 

        if (target) {
            // linear interpolation
            transform.position = Vector3.Lerp(transform.position, target.position, m_speed) + new Vector3(0.0f, 0.0f, -10.0f);
        }
	}
}

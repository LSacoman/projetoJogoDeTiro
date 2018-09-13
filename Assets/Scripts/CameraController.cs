using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform lookAt;
    public GameObject gameover;
    float angle;
    Vector3 offset;

    private void Start()
    {
        offset = lookAt.transform.position - transform.position;
    }

    private void LateUpdate()
    {
        if (lookAt != null)
        {
            float desiredAngle = lookAt.transform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
            transform.position = lookAt.transform.position - (rotation * offset);
            transform.LookAt(lookAt.position);
        }
        else
        {
            gameover.SetActive(true);
            Time.timeScale = 0.0f;
        }


        
    }
}

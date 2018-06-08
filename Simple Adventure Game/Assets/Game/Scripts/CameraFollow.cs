using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public float scale = 4f;

    private Transform targetTrans;

    private void Awake()
    {
        Camera cam = GetComponent<Camera>();
        cam.orthographicSize = (Screen.height / 2f) / scale;
    }

    private void Start()
    {
        targetTrans = target.transform;
    }

    private void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(targetTrans.position.x, targetTrans.position.y, transform.position.z);
        }
    }
}

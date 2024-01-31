using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody rb;

    public Dot currentpath;
    bool isRuning;

    Vector3 refval;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, currentpath.transform.   position, ref refval, 0.2f);

        if (Input.GetKeyDown(KeyCode.W) && currentpath.forward != null)
        {
            isRuning = true;
        }

        if (isRuning)
        {
            while (currentpath.forward != null && Vector3.Distance(transform.position, currentpath.transform.position) < 1)
            {
                currentpath = currentpath.forward;
            }
        }
    }
}

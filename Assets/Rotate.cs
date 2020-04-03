using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed; //set it in the  inspector
    public Vector3 localEulerAngles = new Vector3(0, 180, 0);

    void Update()
    {
        rotate();
    }


    void rotate()
    {


        transform.Rotate(new Vector3(0, 5, 0), Space.Self);


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunMovement : MonoBehaviour
{
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("Rotate target not specified. Defaulting to parent Gameobject");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate takes three arguments, first is Vector to rotate around
        //Second is a vector that axis to rotate around
        //Third is the degrees ro rotate, in this case the speed per second
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}

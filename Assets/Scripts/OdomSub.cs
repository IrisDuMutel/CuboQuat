using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twist = RosMessageTypes.Geometry.Twist;

public class OdomSub : MonoBehaviour
{
    private Transform _transform;
    private Vector3 vel;
    public Rigidbody _rb;
    public RFHandTransform _rftrans;
    // Start is called before the first frame update
    void Start() 
    {

        ROSConnection.instance.Subscribe<Twist>("CubeCommand", _callback);

    }
    void _callback(Twist data)
    {
        float vel_x = (float)data.linear.x;
        float vel_y = (float)data.linear.y;
        float vel_z = (float)data.linear.z;
        vel = new Vector3(vel_x,vel_y,vel_z); 
    }

    // Update is called once per frame
    void Update()
    {
        
        _rftrans.Right2Left(_rb,vel);

        
    }
}

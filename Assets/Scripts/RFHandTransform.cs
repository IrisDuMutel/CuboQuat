using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFHandTransform : MonoBehaviour
{

    
    public void Right2Left(Transform _transform, Vector3 vel)
    {
        // // Orientation
        // var rot = _transform.rotation;
        // _transform.transform.rotation = new Quaternion(rot[0],-rot[1],-rot[3],-rot[2]);

        // // Position
        // var pos = _transform.position;
        // _transform.transform.position = new Vector3(pos[0],pos[2],pos[1]);

        // // Velocity lin
        // var vel = _rb.velocity;
        _transform.transform.position = new Vector3(vel[0],vel[2],vel[1]);

        // // Velocity ang
        // var ang = _rb.angularVelocity;
        // _transform.transform.position = new Vector3(ang[0],ang[2],ang[1]);

    }

    public void Left2Right(Transform _transform, Rigidbody _rb)
    {
        // Orientation
        var rot = _transform.rotation;
        _transform.transform.rotation = new Quaternion(rot[0],-rot[1],-rot[3],-rot[2]);

        // Position
        var pos = _transform.position;
        _transform.transform.position = new Vector3(pos[0],pos[2],pos[1]);

        // Velocity lin
        var vel = _rb.velocity;
        _transform.transform.position = new Vector3(vel[0],vel[2],vel[1]);

        // Velocity ang
        var ang = _rb.angularVelocity;
        _transform.transform.position = new Vector3(ang[0],ang[2],ang[1]);
    }
}

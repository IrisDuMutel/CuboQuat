using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFHandTransform : MonoBehaviour
{

    private Quaternion orient;
    private Vector3 posit;
    private Vector3 lin_vel;
    private Vector3 ang_vel;

    // public RFHandTransform(Transform transform, Rigidbody rigidB)
    // {
    //    _transf = transform;
    //    _rigidB = rigidB;
    // }
    public void Right2Left(Transform _transform, Rigidbody _rb , Vector3 pos, Quaternion rot, Vector3 vel, Vector3 ang)
    {
        // // Orientation
        // var rot = _transform.rotation;
        // _transform.rotation = new Quaternion(rot[0],-rot[1],-rot[3],-rot[2]);

        // Position
        // var pos = _transform.position;
        // _transform.position = new Vector3(pos[0],pos[2],pos[1]);

        // // Velocity lin
        // var vel = _rb.velocity;
        _rb.velocity = new Vector3(vel[0],-1f*vel[2],vel[1]);

        // // Velocity ang
        // var ang = _rb.angularVelocity;
        _rb.angularVelocity = new Vector3(ang[0],ang[2],ang[1]);

    }

    public (Quaternion orient, Vector3 posit, Vector3 lin_vel, Vector3 ang_vel) Left2Right(Transform _transf, Rigidbody _rigidB)
    {
        
        
        // Orientation

        var rot = _transf.rotation;
        Debug.Log(rot);
        orient = new Quaternion(-1f*rot.x,-1f*rot.z,-1f*rot.y,rot.w);

        // Position
        var pos = _transf.position;
        posit = new Vector3(pos[0],pos[2],-1f*pos[1]);

        // Velocity lin
        var vel = _rigidB.velocity;
        lin_vel = new Vector3(vel[0],vel[2],vel[1]);

        // Velocity ang
        var ang = _rigidB.angularVelocity;
        ang_vel = new Vector3(ang[0],ang[2],ang[1]);
        return (orient,posit,lin_vel,ang_vel);
    }
}

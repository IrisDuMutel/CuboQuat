using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatChBasis : MonoBehaviour
{
    public Transform cube; 
    // Start is called before the first frame update
    private Quaternion rot;
    void Start()
    {
        var rot = cube.rotation;
        cube.transform.rotation = new Quaternion(rot[0],-rot[1],-rot[3],-rot[2]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // cube.Rotate(0,20f,0);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(cube.position,cube.position+new Vector3(1,0,0));
        
    }
}

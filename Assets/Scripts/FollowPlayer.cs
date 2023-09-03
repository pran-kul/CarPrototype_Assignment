using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset ;
    List<Vector3> cameraAngles = new List<Vector3>();
    bool sideCamera= false;

    // Start is called before the first frame update
    void Start()
    {
        cameraAngles.Add(new Vector3(0, 5, -7));
        cameraAngles.Add(new Vector3(0, 5, 2));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(sideCamera)
            {
                offset = cameraAngles[0];
                sideCamera = false;
            }
            else
            {
                offset = cameraAngles[1];
                sideCamera = true;
            }
        }
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
   
}

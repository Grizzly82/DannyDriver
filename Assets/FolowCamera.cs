using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //This is going to follow the Car around the scene
    // Start is called before the first frame update

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
        
    }
}

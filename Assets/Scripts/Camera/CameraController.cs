using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Transform playerTransform;
    private Vector3 offset;
    
    
    void Start()
    {
        offset = transform.position - playerTransform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deneme = new Vector3(0f, 0f, playerTransform.position.z);

        transform.position = new Vector3(transform.position.x, transform.position.y, playerTransform.position.z + offset.z);
            
            //playerTransform.position + offset;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionController : MonoBehaviour
{

    private void Start()
    {
        Time.timeScale = 1;

    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("coll");
        GameObject Cube = collision.GetContact(0).otherCollider.gameObject;

        if (collision.gameObject.tag.Equals("Player") && this.gameObject.tag.Equals("Cube"))
        {
            //Debug.Log("ekleme "+this.gameObject.name +" tag: "+this.gameObject.tag);
            PlayerStackController.Instance.AddCube(this.gameObject);
            
            
        }
        
    }
    
}

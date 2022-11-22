using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierCollision : MonoBehaviour
{
    public bool  isColllision = false;
    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("oldu");
        GameObject Cube = collision.GetContact(0).otherCollider.gameObject;
        Debug.Log(Cube.name);
        if (Cube.tag.Equals("MainCube")&& !isColllision)
        {
            PlayerStackController.Instance.DeleteCube(Cube);
            isColllision = true;
            //collision.transform.Translate(collision.transform.forward * 0.043f);
            //var rg = collision.gameObject.GetComponent<Rigidbody>();
            //rg.AddForce(collision.gameObject.transform.forward*10);
            //GetComponent<Collider>().enabled = false;
            //Cube.GetComponent<Collider>().enabled = false;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("exit");
        //PlayerStackController.Instance.arrangePosition();
        PlayerStackController.Instance.getInput = true;
        //isColllision = false;
     
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    // Start is called before the first frame update

    // Start is called before the first frame update
    float HorizontalBoundryLeft = -0.17f;
    float HorizontalBoundryRight = 0.1486f;
    float inputVelocity = 0.1f;
    float mouseInitPos;
    //bool playOn = false;

    //public static void Play()
    //{
    //    playOn = false;
    //}
    private void Update()
    {
        //Debug.Log("input")
        //if(PlayerStackController.Instance.getInput)
            GetInput();
    }

   
    void GetInput()
    {

       

        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("btn down kontrol:");
            mouseInitPos = Input.mousePosition.x;
            inputVelocity = 0.1f;
           
           
        }
        else if (Input.GetMouseButton(0))
        {
            float tranfeNum = Input.mousePosition.x - mouseInitPos;
            float x = tranfeNum * Time.deltaTime * inputVelocity;
            if (transform.position.x + x < HorizontalBoundryRight && transform.position.x + x > HorizontalBoundryLeft)
            {
                transform.Translate(x, 0f, 0f);
                mouseInitPos = Input.mousePosition.x;
            }
              
                
              
                
           
        }
        else if (Input.GetMouseButtonUp(0))
        {
            inputVelocity = 0;

        }
      
      
    }
}

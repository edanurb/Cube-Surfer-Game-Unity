using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStackController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lastObject;
    public List<GameObject> CubeStack = new List<GameObject>();
    public bool getInput = true;
    /*ublic float initPos=*/
    public static PlayerStackController Instance;
    public GameObject mainCube;
    public GameObject player;

    private void Awake()
    {
        CubeStack.Add(lastObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }


    public void AddCube(GameObject Cube)
    {
        print("lastobj " + lastObject.name);
        GameObject tempLast = Cube;
        Cube.transform.position = lastObject.transform.position;
        transform.position += new Vector3(0f, 0.043f, 0);
        Cube.transform.SetParent(transform);
        Cube.gameObject.tag = "MainCube";
        lastObject = tempLast;
        CubeStack.Add(lastObject);
      
        


    }
    //private void Update()
    //{
    //    player.transform.position = mainCube.transform.position+ new Vector3(0f, 0.03f, 0);
            
    //}
    //private void LateUpdate()
    //{
    //    transform.position = mainCube.transform.position + new Vector3(0f, 0.03f, 0);
    //}
    //public void arrangePosition()
    //{
    //    float init = 4.0743f;
    //    float val = 0.043f;
    //    //for (int i = 0; i < CubeStack.Count; i++)
    //    //{

    //    //    CubeStack[i].transform.position = new Vector3(CubeStack[i].transform.position.x, init, CubeStack[i].transform.position.z);
    //    //    init += val;
    //    //}
    //}
    public void DeleteCube(GameObject Cube)
    {
        getInput = false;
        Debug.Log("delete count"+ CubeStack.Count.ToString());
        if (CubeStack.Count > 1)
        {
            Debug.Log("delete "+lastObject.name);
            Cube.transform.parent = null;
            Cube.tag = "Untagged";
            //arrangePosition();
            //var rigidBody = Cube.GetComponent<Rigidbody>();
            //rigidBody.constraints = RigidbodyConstraints.None;
            //rigidBody.freezeRotation=true;
            
            CubeStack.Remove(Cube);
            if (CubeStack.Count == 0)
            {
                Debug.Log("delete if");
                lastObject = null; 
                CanvasManager.Instance.failedCanvas();
                AnimationController.Instance.dieAnimation();
                Time.timeScale = 0;
                
            }
            else
            {
                Debug.Log("delete else");
                lastObject = CubeStack[CubeStack.Count - 1];
           
            }

        }
        else
        {
            Debug.Log("game over");
            CanvasManager.Instance.failedCanvas();
            AnimationController.Instance.dieAnimation();
            Time.timeScale = 0;
        }
        //Debug.Log("delete finish " + lastObject.name);


    }
    

}

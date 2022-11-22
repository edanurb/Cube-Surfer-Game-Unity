using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static CanvasManager Instance;
    public GameObject finishCanvasObj;
    public GameObject failedCanvasObj,finishGameObj;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
        

    }
    public void finishCanvas()
    {
        Instantiate(finishCanvasObj, new Vector3(0f, 0, 0), Quaternion.identity);
    }
    public void failedCanvas()
    {
        Instantiate(failedCanvasObj, new Vector3(0f, 0, 0), Quaternion.identity);
    }
    public void finishGameCanvas()
    {
        Instantiate(finishGameObj, new Vector3(0f, 0, 0), Quaternion.identity);

    }

}

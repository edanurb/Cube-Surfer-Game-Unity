using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity = 0.4f;
    //private void Awake()
    //{
    //    Time.timeScale = 1;
    //}
    private void FixedUpdate()
    {
        transform.position += transform.forward * Time.fixedDeltaTime * velocity;

        //Debug.Log("coin num:"+CoinManager.Instance.Score);
    }
    
}

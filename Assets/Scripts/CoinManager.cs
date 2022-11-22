using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static CoinManager Instance;
    public int Score=0;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            
        }
        else
        {
          
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }
    public void increaseScore()
    {
        Score += 1;
    }
}

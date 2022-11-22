using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    public void retry()
    {
        Debug.Log("gir");
        //int level = PlayerPrefs.GetInt("Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

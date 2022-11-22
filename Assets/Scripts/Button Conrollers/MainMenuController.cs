using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Level"))
        {
            PlayerPrefs.SetInt("Level", 1);
        }
    }

    public void PlayBtn()
    {
        int level = PlayerPrefs.GetInt("Level");
    
        SceneManager.LoadScene("Assets/Scenes/Levels/Level" + level.ToString() + ".unity");
    }

}

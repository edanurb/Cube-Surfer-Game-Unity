using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelController : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextLevel()
    {
        int level = PlayerPrefs.GetInt("Level");
        level += 1;
        PlayerPrefs.SetInt("Level", level);
        SceneManager.LoadScene("Assets/Scenes/Levels/Level" + level.ToString() + ".unity");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainController : MonoBehaviour
{
    // Start is called before the first frame update
    public void playAgain()
    {
        PlayerPrefs.SetInt("Level", 1);
        SceneManager.LoadScene("Assets/Scenes/Levels/Level1.unity");
    }
}

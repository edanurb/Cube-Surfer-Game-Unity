using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            int level = PlayerPrefs.GetInt("Level");
            Debug.Log("LEVEL"+ level.ToString());
            if (level == 4) {
                AnimationController.Instance.finishAnimation();
                CanvasManager.Instance.finishGameCanvas();
            }
            else
            {
                AnimationController.Instance.finishAnimation();
                CanvasManager.Instance.finishCanvas();
            }
               
            Time.timeScale = 0;
                
        }
    }
}

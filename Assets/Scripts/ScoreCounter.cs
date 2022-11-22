using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreTxt;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Score"))
        {
            PlayerPrefs.SetInt("Score", 0);
        }
        //Debug("score: girdi");
        scoreTxt.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Coin"))
        {
            Destroy(other.gameObject);
    
            int score = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", score + 1);

            scoreTxt.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();

        }
    }
}

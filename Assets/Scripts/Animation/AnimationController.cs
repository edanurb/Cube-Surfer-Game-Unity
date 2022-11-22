using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    public static AnimationController Instance { get; private set; }

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void dieAnimation()
    {
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        anim.SetTrigger("Die");
    }
    public void finishAnimation()
    {
        anim.updateMode = AnimatorUpdateMode.UnscaledTime;
        anim.SetTrigger("Finish");
    }

}

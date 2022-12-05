using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniWhenEnemyDie : MonoBehaviour
{
    public Animator camAnim;

    public void CamShake()
    {
        camAnim.SetTrigger("Shake");
    }
}

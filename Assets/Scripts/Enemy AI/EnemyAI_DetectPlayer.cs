using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_DetectPlayer : MonoBehaviour
{
    public enum Mode { Patrol, Wait }
    public Mode AI_mode;

    public EnemyAI_FollowPlayer enemyAI_fp;
    public EnemyAI_Patrol enemyAI_pat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (AI_mode == Mode.Patrol)
        {
            if (collision.tag == "Player")
            {
                if (enemyAI_fp != null)
                    enemyAI_fp.enabled = true;

                if(enemyAI_pat != null)
                    enemyAI_pat.enabled = false;
            }
        }

        if (AI_mode == Mode.Wait)
        {
            if (collision.tag == "Player")
            {
                if (enemyAI_fp != null)
                    enemyAI_fp.enabled = true;
            }
        }
    }
}

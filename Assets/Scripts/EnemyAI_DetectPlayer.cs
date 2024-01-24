using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI_DetectPlayer : MonoBehaviour
{
    public EnemyAI_FollowPlayer enemyAI_fp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            if (enemyAI_fp != null)
                enemyAI_fp.enabled = true;
    }
}

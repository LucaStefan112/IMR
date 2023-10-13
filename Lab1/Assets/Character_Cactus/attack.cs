using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    
    public GameObject player1;
    public GameObject player2;

    void Start()
    {
    }

    // Pass the player and animator objects as parameters
    public void SetPlayersAndAnimators(GameObject player1, GameObject player2, Animator anim1, Animator anim2)
    {
        this.player1 = player1;
        this.player2 = player2;
        this.animator1 = anim1;
        this.animator2 = anim2;
    }

    void Update()
    {
        if (player1 == null || player2 == null || animator1 == null || animator2 == null)
        {
            Debug.LogError("Player or Animator objects not set.");
            return;
        }

        var position1 = player1.transform.position;
        var position2 = player2.transform.position;

        if (Vector3.Distance(position1, position2) < 0.1f)
        {
            animator1.SetBool("isAttacking", true);
            animator2.SetBool("isAttacking", true);
        }
        else
        {
            animator1.SetBool("isAttacking", false);
            animator2.SetBool("isAttacking", false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProximity : MonoBehaviour
{
    public float proximityDistance = 3f; // Adjust this value to change the proximity distance.

    private GameObject player1;
    private GameObject player2;
    private Animator animator1;
    private Animator animator2;

    void Start()
    {
        // Find and store the player GameObjects and their Animators using tags.
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");

        if (player1 != null)
            animator1 = player1.GetComponent<Animator>();

        if (player2 != null)
            animator2 = player2.GetComponent<Animator>();
    }

    void Update()
    {
        if (player1 == null || player2 == null)
            return;

        // Calculate the distance between the two players.
        float distance = Vector3.Distance(player1.transform.position, player2.transform.position);

        // Check if the players are close within the specified proximity distance.
        if (distance < proximityDistance)
        {
            // Set 'isAttacking' to true for both players' Animators.
            if (animator1 != null)
                animator1.SetBool("isAttacking", true);

            if (animator2 != null)
                animator2.SetBool("isAttacking", true);
        }
        else
        {
            // Set 'isAttacking' to false for both players' Animators.
            if (animator1 != null)
                animator1.SetBool("isAttacking", false);

            if (animator2 != null)
                animator2.SetBool("isAttacking", false);
        }
    }
}

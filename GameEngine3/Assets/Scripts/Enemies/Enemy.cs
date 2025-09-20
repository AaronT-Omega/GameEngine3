using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Transform playerTarget; // Assign the player's Transform in the Inspector
    public float speed = 3f;

    public abstract void Attack();
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;

    private void Start()
    {
        player.Damage(10);
    }
}

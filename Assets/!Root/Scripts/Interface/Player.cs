using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour, IHeathable, IDamageable
{
    [SerializeField] private float _heath = 100;

    public float Heath
    {
        get => _heath;
        set => _heath = value;
    }

    public void Damage(float value)
    {
        Heath -= value;
    }
}

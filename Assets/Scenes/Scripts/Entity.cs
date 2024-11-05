using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    [Serializable]
    public struct EntityStats
    {
        public float MovementSpeed;
        public float MaxHealth;

    }
    [NonSerialized]
    public float CurrentHealth;
    bool dead = false;
    public EntityStats stats;
    private void Start(){
        CurrentHealth = stats.MaxHealth;
    }
}
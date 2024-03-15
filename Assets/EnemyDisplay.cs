using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisplay : MonoBehaviour
{
    [SerializeField] private EnemyInfo _enemyInfo;
    [SerializeField] private Health _health;
    [SerializeField] private TargetChasing _target;
    [SerializeField] private Zombie _zombie;
    [SerializeField] private ZombieAttack _zombieAttack;
 
    void Start()
    {
        gameObject.name = _enemyInfo._name;
        _health._healthPoint = _enemyInfo._maxHealth;
        _health._maxHealth = _enemyInfo._maxHealth;
        _target._speed = _enemyInfo._speed;
        _target._timeDelay = _enemyInfo._delayAttack;
        _zombie._timeDelay = _enemyInfo._delayHit;
        _zombieAttack._dmg = _enemyInfo._dmg;
       
    }

  
}

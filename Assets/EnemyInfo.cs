using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu]
public class EnemyInfo : ScriptableObject
{
    public string _name;
    public string _description;
    public int _speed;
    public int _maxHealth;
    public float _delayAttack;
    public float _delayHit;
    public int _dmg;
}

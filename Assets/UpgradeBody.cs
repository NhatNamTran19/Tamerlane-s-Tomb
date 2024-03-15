using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class UpgradeBody : MonoBehaviour
{
    [SerializeField] private Material _material;

    public void UpdateBody()
    { 
        _material.EnableKeyword("_EMISSION");
    }
}

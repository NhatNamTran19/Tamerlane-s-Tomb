using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffDirectLight : MonoBehaviour
{
    [SerializeField] private GameObject _directLight;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            _directLight.gameObject.SetActive(false);
        }
    }

}

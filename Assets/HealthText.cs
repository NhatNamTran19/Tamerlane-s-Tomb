using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour
{
    [SerializeField] private TMP_Text _ammoText;
    [SerializeField] private Health _health;

    // Update is called once per frame
    void Update()
    {
        _ammoText.text = _health._healthPoint.ToString();
    }
}

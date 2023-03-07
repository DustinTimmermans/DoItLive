using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStateText : MonoBehaviour
{
    public TextMeshProUGUI _state;

    private string _name;

    private void Awake()
    {
        _state = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _state.text = _name;
    }

    public void UpdateName(string name)
    {
        _name = name;
    }
}

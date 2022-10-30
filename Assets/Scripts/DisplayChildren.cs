using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayChildren : MonoBehaviour
{
    [SerializeField] GameObject parentObject;
    TextMeshProUGUI textMeshProUGUI;
    string baseText; 
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = gameObject.GetComponent<TextMeshProUGUI>();
        baseText = textMeshProUGUI.text;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = baseText+parentObject.transform.childCount;

    }
}

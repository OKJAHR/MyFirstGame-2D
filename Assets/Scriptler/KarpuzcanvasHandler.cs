using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//Preload
public class KarpuzcanvasHandler : MonoBehaviour
{
    public TextMeshProUGUI karpuzText;
    void Update()
    {
        karpuzText.text = GameManager.instance.karpuzSayisi.ToString();
    }
}

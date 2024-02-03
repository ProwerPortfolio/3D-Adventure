using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField] private Bag bag;
    [SerializeField] private Text text;

    private void Start()
    {
        bag.ChangeAmountKey.AddListener(OnChangeAmountKey);
    }

    private void OnDestroy()
    {
        bag.ChangeAmountKey.RemoveListener(OnChangeAmountKey);
    }

    private void OnChangeAmountKey()
    {
        text.text = bag.GetAmountKey().ToString();
    }
}

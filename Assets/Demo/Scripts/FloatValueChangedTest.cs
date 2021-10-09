using UnityEngine;
using UnityEngine.UI;

public class FloatValueChangedTest : MonoBehaviour
{
    [SerializeField] private Text text = null;

    public void FloatToText(float value)
    {
        text.text = value.ToString();
    }
}

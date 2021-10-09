using UnityEngine;
using UnityEngine.UI;
using GameArchitecture.References;
using GameArchitecture.Values;

public class FloatReferenceTest : MonoBehaviour
{
    [SerializeField] private Text floatValueText = null;
    [SerializeField] private FloatReference testFloatReference = null;

    private void Awake()
    {
        testFloatReference.OnValueChanged.AddListener(HandleTestFloatValueChanged);
    }

    private void OnDestroy()
    {
        testFloatReference.OnValueChanged.RemoveListener(HandleTestFloatValueChanged);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            testFloatReference.Value += 1;
        }

        floatValueText.text = testFloatReference.Value.ToString();
    }

    private void HandleTestFloatValueChanged(float value)
    {
        Debug.Log("New value " + value);
    }
}

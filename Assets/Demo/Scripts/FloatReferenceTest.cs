using UnityEngine;
using UnityEngine.UI;
using GameArchitecture.GameReferences;
using GameArchitecture.GameVariables;

public class FloatReferenceTest : MonoBehaviour
{
    [SerializeField] private Text floatValueText = null;
    [SerializeField] private FloatVariable testFloatVariable = null;
    [SerializeField] private FloatReference testFloatReference = null;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            testFloatVariable.Value += 1f;
        }

        floatValueText.text = testFloatReference.Value.ToString();
    }
}

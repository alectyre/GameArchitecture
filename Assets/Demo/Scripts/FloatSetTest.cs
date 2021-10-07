using UnityEngine;
using UnityEngine.UI;
using GameArchitecture.Collections;

public class FloatSetTest : MonoBehaviour
{
    [SerializeField] private FloatSet testFloatSet = null;
    [SerializeField] private Text itemsText = null;
    [SerializeField] private Text runTimeItemsText = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            testFloatSet.Add(1f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            testFloatSet.Add(2f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            testFloatSet.Add(3f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            testFloatSet.Add(4f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            testFloatSet.Add(5f);
        }

        UdpateText();
    }

    private void UdpateText()
    {
        itemsText.text = testFloatSet.ItemsToString();
        runTimeItemsText.text = testFloatSet.RuntimeItemsToString();
    }
}

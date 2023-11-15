using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateProvider : MonoBehaviour
{
    [SerializeField] private DelegateConsumer consumer;

    [ContextMenu("Test logic consumption")]
    private void TestLogicConsumption()
    {
        //TODO (DONE): Add the parameter here to handle the secret.
        //You can log the value to test it :)

        if (consumer != null)
        {
            consumer.ConsumeDelegate(ShowSecret);
        }
        else
        {
            Debug.Log($"{name} <color-RED>ERROR!<color> The method to delegate was not provided in DelegateConsumer.");
        }
    }

    private void ShowSecret(string secret)
    {
        Debug.Log($"{name} give secret: {secret}");
    }
}

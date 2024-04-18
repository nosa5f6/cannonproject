using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    Text textComponent;

    void Start()
    {
        textComponent = GetComponent<Text>();

        textComponent.text = "Hello, World!";
    }

}

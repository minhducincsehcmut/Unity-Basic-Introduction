using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import TextMeshPro namespace

public class ChangeTextOnClick : MonoBehaviour
{
    public Button button;
    public TMP_Text buttonText; // Use TMP_Text instead of Text

    // Start is called before the first frame update
    void Start()
    {
        // Attach listener to button click event
        button.onClick.AddListener(ChangeButtonText);
    }

    // Function to handle button click event
    void ChangeButtonText()
    {
        // Change the text of the button
        buttonText.text = "New Text";
    }
}

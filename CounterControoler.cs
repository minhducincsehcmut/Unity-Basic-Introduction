
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterController : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private int counter = 0;
    public Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(IncrementCounter);
    }

    void IncrementCounter()
    {
        counter++;
        counterText.text = counter.ToString();
    }
}

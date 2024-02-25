using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public GameObject panelToToggle;
    public ButtonController Button;

    void Start()
    {
        // Ẩn panel khi bắt đầu
        panelToToggle.SetActive(false);

        // Gắn sự kiện cho button
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TogglePanel);
    }

    void TogglePanel()
    {
        // Đảo trạng thái của panel (nếu đang ẩn thì hiển thị và ngược lại)
        panelToToggle.SetActive(!panelToToggle.activeSelf);
    }
}

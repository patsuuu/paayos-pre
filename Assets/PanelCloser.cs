using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloser : MonoBehaviour
{
    public Panel panelToClose;

    public void ClosePanel()
    {
        if (panelToClose != null)
        {
            panelToClose.Hide();
        }
        else
        {
            Debug.LogWarning("PanelToClose is null. Make sure a Panel object is assigned in the Inspector.");
        }
    }
}

public interface Panel
{
    void Hide();
}

public class ExamplePanel : MonoBehaviour, Panel
{
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
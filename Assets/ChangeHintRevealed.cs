using System.Diagnostics;
using TMPro;
using UnityEngine;

public class ChangeHintRevealed : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    private string option;

    public TextAsset DropdownMenuOptions;
    public TMP_Text HintBox;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        dropdown = GetComponent<TMP_Dropdown>(); 
        option = dropdown.options[0].text;
    }

    public void OnDropdownChanged(int index)
    {
        option = dropdown.options[index].text;
    }

    public void onClick()
    {
        HintBox.text = GetValue(option);
        Canvas.ForceUpdateCanvases();
    }

    public string GetValue(string key)
    {
        string[] lines = DropdownMenuOptions.text.Split(new[] { "\r\n", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < lines.Length - 1; i++)
        {
            if (lines[i] == key)
            {
                return lines[i + 1];
            }
        }

        return null;
    }
}

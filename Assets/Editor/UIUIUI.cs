using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UIUIUI : EditorWindow
{
    private TextField _textField;
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/UIUIUI")]
    public static void ShowExample()
    {
        UIUIUI wnd = GetWindow<UIUIUI>();
        wnd.titleContent = new GUIContent("UIUIUI");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // Instantiate UXML
        VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        root.Add(labelFromUXML);

        var btn = root.Q<Button>("Log-Btn");
        btn.text = "UwU";

        btn.clicked += OnButtonClicked;

        _textField = root.Q<TextField>();
    }
    
    private void OnButtonClicked()
    {
        Debug.Log(_textField.value);
    }
}

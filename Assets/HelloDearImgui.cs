using ImGuiNET;
using ImGuiNET.Unity;
using UnityEngine;

public sealed class HelloDearImgui : MonoBehaviour
{
    private void OnEnable()
    {
        ImGuiUn.Layout += OnImGUI;
    }
    
    private void OnDisable()
    {
        ImGuiUn.Layout -= OnImGUI;
    }
    
    private void OnImGUI()
    {
        ImGui.ShowDemoWindow();
    }
}

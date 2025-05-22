using ImGuiNET;
using ImGuiNET.Unity;
using UnityEngine;

public sealed class HelloDearImgui : MonoBehaviour
{
    private void OnEnable()
    {
        DearImGui.AddDrawRequest(OnShouldRenderer);
        ImGuiUn.Layout += OnImGUI;
    }
    
    private void OnDisable()
    {
        DearImGui.RemoveDrawRequest(OnShouldRenderer);
        ImGuiUn.Layout -= OnImGUI;
    }
    
    private bool OnShouldRenderer()
    {
        return enabled && gameObject.activeInHierarchy;
    }
    
    private void OnImGUI()
    {
        ImGui.ShowDemoWindow();
    }
}

using UnityEngine;
using System.Collections;
public class ExitButton : MonoBehaviour
{
    void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
#endif
    }
    public void OnClick()
    {
        Quit();
    }
}
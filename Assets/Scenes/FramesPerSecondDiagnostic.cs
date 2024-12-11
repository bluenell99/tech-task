using UnityEngine;

public class FramesPerSecondDiagnostic : Diagnostic
{
    public override float GetDiagnostic()
    {
        float current = (int)(1f / Time.unscaledDeltaTime);
        return current;
    }
}
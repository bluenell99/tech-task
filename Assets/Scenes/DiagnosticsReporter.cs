using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagnosticsReporter : MonoBehaviour
{
    
    [SerializeField] private List<Diagnostic> _diagnostics;
    
    private void Start()
    {
        StartCoroutine(Refresh());
    }

    private IEnumerator Refresh()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            GetDiagnostics();
            
        }
    }

    private void GetDiagnostics()
    {
        foreach (var diagnostic in _diagnostics)
        {
            float text = diagnostic.GetDiagnostic();
            diagnostic.SetDiagnostic(text);
        }
    }
}
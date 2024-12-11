using TMPro;
using UnityEngine;

public abstract class Diagnostic : MonoBehaviour
{

    public string Label { get; private set; }
    public float Measurement { get; private set; }

    [SerializeField] private TextMeshProUGUI _label;
    [SerializeField] private TextMeshProUGUI _measurement;
    
    public void SetDiagnostic(float measurement)
    {
        _measurement.text = measurement.ToString();
    }

    public abstract float GetDiagnostic();

}
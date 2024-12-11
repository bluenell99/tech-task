using UnityEngine;

public class Switcher : MonoBehaviour
{

    [SerializeField] private GameObject _vikingEnvironment;
    [SerializeField] private GameObject _cubeEnvironment;

    [SerializeField] private MeshRenderer _capsule;
    [SerializeField] private GameObject _viking;
    public void SwitchToCube()
    {
        _vikingEnvironment.SetActive(false);
        _cubeEnvironment.SetActive(true);
        _capsule.enabled = true;
        _viking.SetActive(false);
    }
    
    public void SwitchToViking()
    {
        _vikingEnvironment.SetActive(true);
        _cubeEnvironment.SetActive(false);
        _capsule.enabled = false;
        _viking.SetActive(true);
    }
}


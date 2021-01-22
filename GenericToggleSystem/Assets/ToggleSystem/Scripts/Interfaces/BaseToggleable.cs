using UnityEngine;

namespace ToggleSystem.Scripts.Interfaces
{
    public abstract class BaseToggleable : MonoBehaviour
    {
        public abstract void Toggle(bool isEnabled);
    }
}
using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.Core
{
    public class GameObjectToggle : IToggle<GameObject>
    {
        public void Toggle(GameObject button, bool isEnabled)
        {
            button.SetActive(isEnabled);
        }
    }
}


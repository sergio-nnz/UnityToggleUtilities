using ToggleSystem.Scripts.Interfaces;
using UnityEngine;

namespace ToggleSystem.Scripts.Core
{
    public class CanvasToggle : IToggle<Canvas>
    {
        public void Toggle(Canvas canvas, bool isEnabled)
        {
            canvas.enabled = isEnabled;
        }
    }
}
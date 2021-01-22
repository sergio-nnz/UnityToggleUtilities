using ToggleSystem.Scripts.Interfaces;
using UnityEngine.UI;

namespace ToggleSystem.Scripts.Core
{    
    public class ButtonArrayInteractionToggle : IToggle<Button[]>
    {
        public void Toggle(Button[] button, bool isEnabled)
        {
            for (int i = 0; i < button.Length; i++)
            {
                button[i].interactable = isEnabled;
            }
        }
    }
}

using ToggleSystem.Scripts.Interfaces;

namespace ToggleSystem.Scripts.Helpers
{
    public static class ToggleUtils
    {
        public static void MultiToggle(BaseToggleable[] toggleables, bool areEnabled)
        {
            for (var i = 0; i < toggleables.Length; i++)
            {
                toggleables[i].Toggle(areEnabled);
            }
        }
    }
}

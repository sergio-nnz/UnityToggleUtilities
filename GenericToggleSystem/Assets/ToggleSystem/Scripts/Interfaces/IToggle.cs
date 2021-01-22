namespace ToggleSystem.Scripts.Interfaces
{
    public interface IToggle<T>
    {
        void Toggle(T button, bool isEnabled);
    }
}

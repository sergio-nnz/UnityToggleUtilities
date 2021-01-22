using UnityEngine;

namespace ToggleSystem.Scripts.Helpers
{
    public static class MockUtility
    {
        public static T ForComponent<T>() where T : Component
        {
            var mockGameObject = new GameObject();
            return mockGameObject.AddComponent<T>();
        }

        public static T ForClass<T>() where T : new()
        {
            return new T();
        }
    }
}
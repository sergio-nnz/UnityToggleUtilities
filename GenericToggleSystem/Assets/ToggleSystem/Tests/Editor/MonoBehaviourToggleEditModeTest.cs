using NUnit.Framework;
using ToggleSystem.Scripts.Core;
using UnityEngine;

namespace ToggleSystem.Tests.Editor
{
    
    public class MonoBehaviourToggleEditModeTest
    {
        private GameObject _testObject;
        private TestComponent _testComponent;
        private readonly MonoBehaviourToggle<TestComponent> _toggle = new MonoBehaviourToggle<TestComponent>();
        
        [SetUp]
        public void InitializeScene()
        {
            _testObject =  new GameObject();
            _testComponent = _testObject.AddComponent<TestComponent>();
        }

        [TearDown]
        public void RestoreUnityScene()
        {
            Object.DestroyImmediate(_testObject);
        }

        [Test]
        public void ToggleEnablesTheMonoBehaviour()
        {
            _toggle.Toggle(_testComponent, true);

            Assert.True(_testComponent.enabled);
        }

        [Test]
        public void ToggleDisablesTheMonoBehaviour()
        {
            _toggle.Toggle(_testComponent, false);

            Assert.False(_testComponent.enabled);
        }
    }

    class TestComponent : MonoBehaviour
    {
        private void Start()
        {
            
        }
    }
}

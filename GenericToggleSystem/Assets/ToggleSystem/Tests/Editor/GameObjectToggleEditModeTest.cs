using NUnit.Framework;
using ToggleSystem.Scripts.Core;
using UnityEngine;

namespace ToggleSystem.Tests.Editor
{
    public class GameObjectToggleEditModeTest
    {
        private GameObject _testObject;
        private readonly GameObjectToggle _toggle = new GameObjectToggle();
    
        [SetUp]
        public void InitializeScene()
        {
            _testObject =  new GameObject();
        }
 
        [TearDown]
        public void CleanScene()
        {
            Object.DestroyImmediate(_testObject);
        }
     
        [Test]
        public void ToggleEnablesTheGameObject()
        {
            _toggle.Toggle(_testObject, true);

            Assert.True(_testObject.activeSelf);
        }

        [Test]
        public void ToggleDisablesTheGameObject()
        {
            _toggle.Toggle(_testObject, false);

            Assert.False(_testObject.activeSelf);
        }
    }
}

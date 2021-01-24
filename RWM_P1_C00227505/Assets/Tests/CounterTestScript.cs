using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CounterTestScript
    {

        [UnityTest]
        public IEnumerator CounterTestScriptWithEnumeratorPasses()
        {
            GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

            GameScript game = gameGameObject.GetComponent<GameScript>();

            GameObject canvas = game.getCanvas();

            GameObject Counter = canvas.transform.GetChild(4).gameObject;

            int prevAmount = Counter.GetComponent<HudCounter>().getAmount();

            Counter.GetComponent<HudCounter>().addAmount();

            int newAmount = Counter.GetComponent<HudCounter>().getAmount();

            Assert.AreNotEqual(prevAmount, newAmount);

            yield return null;
        }
    }
}

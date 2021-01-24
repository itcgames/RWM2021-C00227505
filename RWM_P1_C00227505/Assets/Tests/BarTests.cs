using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BarTests
    {
        

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator BarTestsWithEnumeratorPasses()
        {
            GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

            GameScript game = gameGameObject.GetComponent<GameScript>();

            GameObject player = game.getPlayer();

            GameObject canvas = game.getCanvas();

            float playerstamina = player.GetComponent<playerTest>().Stamina;

            float barValue = canvas.transform.GetChild(3).GetComponent<Bar>().GetBarBalue();

            player.GetComponent<playerTest>().useStamina();

            playerstamina = player.GetComponent<playerTest>().Stamina;

            barValue = canvas.transform.GetChild(3).GetComponent<Bar>().GetBarBalue();

            Assert.AreEqual(playerstamina, barValue);


            yield return null;
        }
    }
}

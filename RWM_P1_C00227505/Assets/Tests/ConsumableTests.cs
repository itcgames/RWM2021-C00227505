using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ConsumableTestScript
    {
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ConsumableHealthPotion()
        {
            GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

            GameScript game = gameGameObject.GetComponent<GameScript>();

            GameObject player = game.getPlayer();

            GameObject canvas = game.getCanvas();

            int playerPrevHealth = player.GetComponent<Health>().health;

            canvas.transform.GetChild(1).GetComponent<Consumable>().use();

            int playerNewHealth = player.GetComponent<Health>().health;

            Assert.AreNotEqual(playerPrevHealth, playerNewHealth);

            yield return null;
        }


    }
}

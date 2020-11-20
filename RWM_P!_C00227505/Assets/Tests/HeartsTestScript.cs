using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HeartsTestScript
    {

        [SetUp]
        public void Setup()
        {
            GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

            GameScript game = gameGameObject.GetComponent<GameScript>();
        }

        [TearDown]
        public void Teardown()
        {
          
        }

        [UnityTest]
        public IEnumerator HealthChangesWithPlayer()
        {
            GameObject gameGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

            GameScript game = gameGameObject.GetComponent<GameScript>();

            GameObject player = game.getPlayer();

            GameObject canvas = game.getCanvas();

            yield return new WaitForSeconds(0.1f);

            int hearts = canvas.transform.GetChild(0).GetComponent<Hearts>().activeHearts;

            int playerhealth = player.GetComponent<Health>().health;

            if(hearts == playerhealth)
            {

                player.GetComponent<Health>().heal();

                yield return new WaitForSeconds(0.1f);

                playerhealth = player.GetComponent<Health>().health;

                hearts = canvas.transform.GetChild(0).GetComponent<Hearts>().activeHearts;

                Assert.AreEqual(hearts , playerhealth);
            }
            else
            {
                yield return null;
            }
        }
    }
}

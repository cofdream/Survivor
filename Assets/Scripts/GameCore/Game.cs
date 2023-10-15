using Cofdream.UI;
using Cofdream.UI.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Survivor
{
    [DisallowMultipleComponent]
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            var asyncOperation = SceneManager.LoadSceneAsync("UI", LoadSceneMode.Additive);
        }

        private void Start()
        {
            if (UIManager.OpenPanel(Resources.Load<GameObject>("UIGamePanel")).TryGetComponent<UIGame>(out var uiGame))
            {
                uiGame.Start = OnStart;
            }
        }

        private void OnStart()
        {
            var playGO = Object.Instantiate(Resources.Load<GameObject>("Player"));
            if (playGO.TryGetComponent<Player>(out var player) == false)
            {
                return;
            }
            var enemyGO = Object.Instantiate(Resources.Load<GameObject>("Enemy"));
            if (enemyGO.TryGetComponent<Enemy>(out var enemy))
            {
                enemy.Player = player;
            }
        }
    }
}

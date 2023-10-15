using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survivor
{
    public class AbilityAttack : Ability
    {
        private float attackTIme;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            attackTIme += Time.deltaTime;
            if (attackTIme > 0.5f)
            {
                var enemys = FindObjectsByType<Enemy>(FindObjectsInactive.Include, FindObjectsSortMode.None);
                foreach (var enemy in enemys)
                {

                }
            }
        }
    }
}

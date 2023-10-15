using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Survivor
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private new Rigidbody2D rigidbody2D;
        [SerializeField] private float movementSpeed = 500;
        [SerializeField] private Player player;

        public Player Player { get { return player; } set { player = value; } }

        void Start()
        {

        }


        void Update()
        {
            if (player == null)
            {
                rigidbody2D.velocity = Vector2.zero;
                return;
            }

            var direction = (player.transform.position - transform.position).normalized;

            rigidbody2D.velocity = direction * movementSpeed * Time.deltaTime;
        }
    }

}
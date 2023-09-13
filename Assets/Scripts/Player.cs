using Cofdream.TwoD;
using UnityEngine;
using UnityEngine.Events;

namespace Survivor
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private new Rigidbody2D rigidbody2D;
        [SerializeField] private float movementSpeed = 700;
        //[SerializeField] private CircleCollider2D hurtBox;
        [SerializeField] private OnTriggerEventDispatcher hurtBox;

        private UnityAction<Collider2D> triggerEnterEvent2D;

        void Start()
        {
            triggerEnterEvent2D = TriggerEnterEvent2D;

            hurtBox.TriggerEnterEvent2D.AddListener(triggerEnterEvent2D);

        }
        private void OnDestroy()
        {
            hurtBox.TriggerEnterEvent2D.RemoveListener(triggerEnterEvent2D);

            triggerEnterEvent2D = null;
        }

        void Update()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");
            var direction = new Vector2(horizontal, vertical).normalized;

            rigidbody2D.velocity = direction * movementSpeed * Time.deltaTime;
        }

        private void TriggerEnterEvent2D(Collider2D collision)
        {
           GameObject.Destroy(this.gameObject);
        }
    }

}
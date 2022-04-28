using UnityEngine;

namespace KID
{
    public class FireControlTest : MonoBehaviour
    {
        [Header("����t��")]
        public float speed = 0.5f;
        [Header("�Ұʱ��")]
        public bool activate = true;

        private void Start()
        {
            Cursor.visible = false;
        }

        private void Update()
        {
            Control();
        }

        /// <summary>
        /// ����G���ե�
        /// </summary>
        private void Control()
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");

            Vector3 move = new Vector3(-y, x, 0);

            transform.Rotate(move * speed * Time.deltaTime);

            Vector3 euler = transform.eulerAngles;
            euler.z = 0;
            transform.eulerAngles = euler;
        }
    }
}

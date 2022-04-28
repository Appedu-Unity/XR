using UnityEngine;

namespace KID
{
    public class FireControlTest : MonoBehaviour
    {
        [Header("控制器速度")]
        public float speed = 0.5f;
        [Header("啟動控制器")]
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
        /// 控制器：測試用
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

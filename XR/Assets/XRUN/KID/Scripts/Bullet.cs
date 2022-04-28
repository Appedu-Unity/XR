using UnityEngine;

namespace KID
{
    /// <summary>
    /// 子彈系統
    /// </summary>
    public class Bullet : MonoBehaviour
    {
        #region 欄位
        [Header("子彈碰撞特效")]
        public GameObject psHitEffect;

        private bool hit;
        #endregion

        #region 事件
        private void OnCollisionEnter(Collision collision)
        {
            Hit(collision);
        }
        #endregion

        #region 方法
        /// <summary>
        /// 碰撞事件
        /// </summary>
        private void Hit(Collision collision)
        {
            if (hit) return;

            hit = true;

            Vector3 pos = collision.contacts[0].point;
            pos.z = 9.9f;
            Quaternion angle = Quaternion.Euler(0, 0, Random.Range(0f, 360f));

            // 彈孔
            GameObject bulletHole = Instantiate(psHitEffect, pos, angle);

            ScoreManager.instance.CheckBulletPositionAndScore(bulletHole.transform);

            Destroy(gameObject);
        }
        #endregion
    }
}

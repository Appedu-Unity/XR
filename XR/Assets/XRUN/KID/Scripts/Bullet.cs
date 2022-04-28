using UnityEngine;

namespace KID
{
    /// <summary>
    /// �l�u�t��
    /// </summary>
    public class Bullet : MonoBehaviour
    {
        #region ���
        [Header("�l�u�I���S��")]
        public GameObject psHitEffect;

        private bool hit;
        #endregion

        #region �ƥ�
        private void OnCollisionEnter(Collision collision)
        {
            Hit(collision);
        }
        #endregion

        #region ��k
        /// <summary>
        /// �I���ƥ�
        /// </summary>
        private void Hit(Collision collision)
        {
            if (hit) return;

            hit = true;

            Vector3 pos = collision.contacts[0].point;
            pos.z = 9.9f;
            Quaternion angle = Quaternion.Euler(0, 0, Random.Range(0f, 360f));

            // �u��
            GameObject bulletHole = Instantiate(psHitEffect, pos, angle);

            ScoreManager.instance.CheckBulletPositionAndScore(bulletHole.transform);

            Destroy(gameObject);
        }
        #endregion
    }
}

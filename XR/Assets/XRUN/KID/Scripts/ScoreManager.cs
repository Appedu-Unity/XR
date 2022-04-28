using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    public class ScoreManager : MonoBehaviour
    {
        /// <summary>
        /// �v�ȳ̤j�b�|�A���չL�� 0.47
        /// </summary>
        [Header("�v�ȳ̤j�b�|"), Range(0, 3)]
        public float radiusSphereBig = 0.47f;
        [Header("�ϥδ��ղy����դ���")]
        public bool testScoreBySphere = true;
        [Header("���ղy��")]
        public Transform testSphere;
        [Header("���ơG�ͦ����ƪ���Τ�����")]
        public Transform traScore;
        [Header("���ƪ���")]
        public GameObject goScore;
        [Header("�������b")]
        public Scrollbar barVertical;

        public static ScoreManager instance;

        private int index;

        private void Awake()
        {
            instance = this;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0, 1, 0, 0.3f);
            Gizmos.DrawSphere(transform.position, radiusSphereBig);
        }

        private void Update()
        {
            if (testScoreBySphere) CheckBulletPositionAndScore(testSphere);
        }

        /// <summary>
        /// �ˬd�l�u�y�ХH�θӱo��
        /// </summary>
        /// <param name="bullet">�l�u�ܧΤ���</param>
        public void CheckBulletPositionAndScore(Transform bullet)
        {
            Vector3 posBullet = bullet.position;
            posBullet.z = transform.position.z;

            float dis = Vector3.Distance(transform.position, posBullet);
            print("�P�����I�Z���G" + dis);

            float score = 10 - dis / radiusSphereBig * 10;
            print("���ơG" + score);
            score = score > 0 ? score : 0;

            GameObject tempScore = Instantiate(goScore, traScore.transform);
            barVertical.value = 0;

            index++;
            Text text = tempScore.transform.Find("�s���P����").GetComponent<Text>();
            text.text = $"�s�� {index.ToString("00")} | ���ơG {score.ToString("00")}";
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    public class ScoreManager : MonoBehaviour
    {
        /// <summary>
        /// 箆程畖代刚筁 0.47
        /// </summary>
        [Header("箆程畖"), Range(0, 3)]
        public float radiusSphereBig = 0.47f;
        [Header("ㄏノ代刚瞴砰代刚だ计")]
        public bool testScoreBySphere = true;
        [Header("代刚瞴砰")]
        public Transform testSphere;
        [Header("だ计ネΘだ计ンノン")]
        public Transform traScore;
        [Header("だ计ン")]
        public GameObject goScore;
        [Header("禸")]
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
        /// 浪琩紆畒夹の赣眔だ
        /// </summary>
        /// <param name="bullet">紆跑じン</param>
        public void CheckBulletPositionAndScore(Transform bullet)
        {
            Vector3 posBullet = bullet.position;
            posBullet.z = transform.position.z;

            float dis = Vector3.Distance(transform.position, posBullet);
            print("籔いみ翴禯瞒" + dis);

            float score = 10 - dis / radiusSphereBig * 10;
            print("だ计" + score);
            score = score > 0 ? score : 0;

            GameObject tempScore = Instantiate(goScore, traScore.transform);
            barVertical.value = 0;

            index++;
            Text text = tempScore.transform.Find("絪腹籔だ计").GetComponent<Text>();
            text.text = $"絪腹 {index.ToString("00")} | だ计 {score.ToString("00")}";
        }
    }
}
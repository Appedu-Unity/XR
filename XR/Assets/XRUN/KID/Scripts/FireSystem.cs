using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace KID
{
	/// <summary>
	/// 秨簀╰参
	/// 祇甮紆紆︽紆计秖传紆
	/// </summary>
	public class FireSystem : MonoBehaviour
	{
        #region 逆
        [Header("紆")]
        public GameObject goBullet;
        [Header("")]
        public AudioClip soundFire;
        [Header("代刚家Αㄏノオ龄秨簀")]
        public bool modeTest = true;
        [Header("紆计秖")]
        public int countBulletCurrent = 1;
        public int countBulletTotal = 10;
        public Text textCountBullet;
        [Header("紆硉"), Range(0, 5000)]
        public float speedBullet = 1200;

        private AudioSource aud;
        /// <summary>
        /// ネΘ紆竚
        /// </summary>
        private Transform traFirePoint;
        #endregion

        #region ㄆン
        private void Start()
        {
            aud = GetComponent<AudioSource>();
            traFirePoint = transform.Find("ネΘ紆竚");
            UpdateCountBulletUI();
        }

        private void Update()
        {
            #region 代刚跋
            if (modeTest)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    Fire();
                }

                if (Input.GetKeyDown(KeyCode.R))
                {
                    Reload();
                }
            }
            #endregion
        }
        #endregion

        #region よ猭
        /// <summary>
        /// 秨簀╰参
        /// </summary>
        public void Fire()
        {
            if (countBulletCurrent > 0)
            {
                countBulletCurrent--;
                aud.PlayOneShot(soundFire, Random.Range(0.7f, 1.2f));
                GameObject temp = Instantiate(goBullet, traFirePoint.position, Quaternion.Euler(90, 0, 0));
                temp.GetComponent<Rigidbody>().AddForce(traFirePoint.forward * speedBullet);
                UpdateCountBulletUI();
            }
        }

        /// <summary>
        /// 传紆╰参
        /// </summary>
        public void Reload()
        {
            if (countBulletCurrent == 0 && countBulletTotal > 0)
            {
                countBulletTotal--;
                countBulletCurrent++;
                UpdateCountBulletUI();
            }
        }

        /// <summary>
        /// 穝紆计秖ざ
        /// </summary>
        private void UpdateCountBulletUI()
        {
            textCountBullet.text = $"{countBulletCurrent} / {countBulletTotal}";
        }
        #endregion
    }
}
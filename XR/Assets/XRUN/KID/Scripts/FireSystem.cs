using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace KID
{
	/// <summary>
	/// �}�j�t��
	/// �o�g�l�u�B�l�u����B�l�u�ƶq�B���u�X
	/// </summary>
	public class FireSystem : MonoBehaviour
	{
        #region ���
        [Header("�l�u")]
        public GameObject goBullet;
        [Header("����")]
        public AudioClip soundFire;
        [Header("���ռҦ��G�ϥΥ���}�j")]
        public bool modeTest = true;
        [Header("�l�u�ƶq")]
        public int countBulletCurrent = 1;
        public int countBulletTotal = 10;
        public Text textCountBullet;
        [Header("�l�u�t��"), Range(0, 5000)]
        public float speedBullet = 1200;

        private AudioSource aud;
        /// <summary>
        /// �ͦ��l�u��m
        /// </summary>
        private Transform traFirePoint;
        #endregion

        #region �ƥ�
        private void Start()
        {
            aud = GetComponent<AudioSource>();
            traFirePoint = transform.Find("�ͦ��l�u��m");
            UpdateCountBulletUI();
        }

        private void Update()
        {
            #region ���հ�
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

        #region ��k
        /// <summary>
        /// �}�j�t��
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
        /// ���u�X�t��
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
        /// ��s�l�u�ƶq����
        /// </summary>
        private void UpdateCountBulletUI()
        {
            textCountBullet.text = $"{countBulletCurrent} / {countBulletTotal}";
        }
        #endregion
    }
}
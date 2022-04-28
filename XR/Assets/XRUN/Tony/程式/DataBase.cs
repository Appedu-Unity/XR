using UnityEngine;

namespace Tony
{
    public class DataBase : MonoBehaviour
    {
        public static DataBase instance; //資料庫實體物件   

        #region 基本資料
        public static string Name;           //名子
        public static string Tall;           //身高
        public static string Weight;         //體重
        public static string Gender;         //性別
        public static string Old;            //年齡
        #endregion

        #region 選擇類型
        public static string GunType;        //槍枝種類
        public static string DistanceType;   //距離種類
        public static string TargetType;     //靶位種類
        #endregion

        //貓咪狀態
        public static string CatState;

        public void Awake()
        {
            instance = this;
        }
    }
}
